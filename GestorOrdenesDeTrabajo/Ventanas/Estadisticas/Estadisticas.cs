using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            chart1.Legends.Clear();
        }

        void loadGrafica()
        {
            var a = OrdenHistorialController.I.GetLista(OrdenStatus.ESPERA);
            var b = OrdenHistorialController.I.GetLista(OrdenStatus.PROCESO);
            var c = OrdenHistorialController.I.GetLista(OrdenStatus.POR_ENTREGAR);
            var d = OrdenHistorialController.I.GetLista(OrdenStatus.ENTREGADA);
            var e = OrdenHistorialController.I.GetLista(OrdenStatus.GARANTIA);
            var f = OrdenHistorialController.I.GetLista(OrdenStatus.GARANTIA_POR_ENTREGAR);
            var g = OrdenHistorialController.I.GetLista(OrdenStatus.GARANTIA_ENTREGADA);

            //TODO add series to chart and get Only necessary data
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

            //Dibuja grafico 
            DrawChart();
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

        private void DrawChart()
        {
            //chart1.Series.Clear();

            //string Serie = "Series1";
            var values = Enum.GetValues(typeof(OrdenStatus));

            int[] y = new int[values.Length];
            string[] x = new string[values.Length];

            int i = 0;
            foreach (int ordenStatus in values)
            {
                x[i] = OrdenStatusManager.ToString(ordenStatus);
                y[i] = OrdenHistorialController.I.GetCountByStatusBetween(ordenStatus, _initDate, _finDate);
                i++;
            }

            //chart1.Series.Add(Serie);
            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.FromKnownColor(KnownColor.ControlLight);
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromKnownColor(KnownColor.ControlLight);
            chart1.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.FromKnownColor(KnownColor.ControlDark);
            chart1.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.FromKnownColor(KnownColor.ControlDark);
            //chart1.Series[0].BorderWidth = 5;
            //chart1.Series[0].IsValueShownAsLabel = true;
            //chart1.Series[0]["RadarDrawingStyle"] = "Line";
            //chart1.Series[0]["CircularLabelsStyle"] = "Horizontal";
            //chart1.Series[Serie]["AreaDrawingStyle"] = AreaDrawingStyle[(AreaSelected) ? 0 : 1];
            //chart1.ChartAreas["ChartArea1"].AxisX.Maximum = esc;
            //chart1.ChartAreas["ChartArea1"].AxisY.Maximum = esc;
            //chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 1;
            //chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 1;
            //chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.LightGray;
            //chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.LightGray;
            //chart1.ChartAreas["ChartArea1"].AxisX.LineColor = chart1.BackColor;
            //chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.LightGray;
            //chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;
        }
    }
}
