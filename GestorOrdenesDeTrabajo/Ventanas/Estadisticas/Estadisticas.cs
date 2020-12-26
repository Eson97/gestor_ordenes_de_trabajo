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

        }

        void loadRefacciones()
        {

        }

        void loadServicio()
        {

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
