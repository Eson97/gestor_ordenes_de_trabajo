using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Estadisticas
{
    public partial class Estadisticas : Form
    {
        private DateTime _initDate;
        private DateTime _finDate;

        public Estadisticas()
        {
            InitializeComponent();
            _initDate = cdtpInit.Value;
            _finDate = cdtpFin.Value;
        }

        void loadGrafica()
        {

        }

        void loadIngresos()
        {
            var a = OrdenRefaccionController.I.GetListaByPaymentBetween(_initDate, _finDate, TipoPago.CHEQUE);
            var b = OrdenRefaccionController.I.GetListaByPaymentBetween(_initDate, _finDate, TipoPago.CREDITO);
            var c = OrdenRefaccionController.I.GetListaByPaymentBetween(_initDate, _finDate, TipoPago.EFECTIVO);
            var d = OrdenRefaccionController.I.GetListaByPaymentBetween(_initDate, _finDate, TipoPago.TERMINAL);
            var e = OrdenRefaccionController.I.GetListaByPaymentBetween(_initDate, _finDate, TipoPago.TRANSFERENCIA);

            var chequeTotal = a.Sum(el => el.Total);
            var creditTotal = b.Sum(el => el.Total);
            var efectivoTotal = c.Sum(el => el.Total);
            var terminalTotal = d.Sum(el => el.Total);
            var transferTotal = e.Sum(el => el.Total);

            var Total = chequeTotal + creditTotal + efectivoTotal + terminalTotal + transferTotal;

            ipCheque.Info = chequeTotal;
            ipCredito.Info = creditTotal;
            ipEfectivo.Info = efectivoTotal;
            ipTerminal.Info = terminalTotal;
            ipTransfe.Info = transferTotal;

            ipNeto.Info = Math.Abs(Total - creditTotal);
            ipTotal.Info = Total;
        }

        void loadRefacciones()
        {
            var listR = OrdenRefaccionController.I.GetListaBetween(_initDate, _finDate);
            var listW = OrdenRefaccionGarantiaController.I.GetListaBetween(_initDate, _finDate);

            var totalR = listR.Sum(el => el.Total);
            var totalW = listW.Sum(el => el.Total);

            var refUsadas = listR.Count;
            var refGarantia = listW.Count;

            ipRefUsadas.Info = refUsadas;
            ipRefGarantia.Info = refGarantia;
            ipRefTotal.Info = refUsadas + refGarantia;
            ipCostoRef.Info = totalR + totalW;
        }

        void loadServicio()
        {
            var listManoObra = OrdenMecanicoController.I.GetListaBetween(_initDate, _finDate);
            var listM = OrdenMecanicoController.I.GetCountMecanicos(_initDate, _finDate);

            var totalManoObra = listManoObra.Sum(el => el.CostoManoObra);
            var totalMecanicos = listM.Count;

            infoPanel2.Info = totalManoObra;
            ipTotalServicio.Info = totalMecanicos;
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (_finDate < _initDate) cdtpFin.Value = _initDate; //si el rango no es valido se corrige alv

            //desplegar mensaje mientras carga?

            loadGrafica();
            loadIngresos();
            loadRefacciones();
            loadServicio();
        }

        private void btnDetalleRefaccion_Click(object sender, EventArgs e)
        {
            //Imprime un reporte detallado de refacciones
        }

        private void btnDetalleServicio_Click(object sender, EventArgs e)
        {
            //Imprime un reporte detallado de servicio por mecanico
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //Imprmime un reporte mas a detalle se todos los campos
        }

        private void cdtpInit_ValueChanged(object sender, EventArgs e)
        {
            _initDate = (sender as DateTimePicker).Value;
        }

        private void cdtpFin_ValueChanged(object sender, EventArgs e)
        {
            _finDate = (sender as DateTimePicker).Value;
        }
    }
}
