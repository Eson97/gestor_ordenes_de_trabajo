using GestorOrdenesDeTrabajo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class NuevaOrden : Form
    {
        Orden orden;

        public NuevaOrden()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            clientDataContainer.Controls
                .OfType<TextBox>().ToList()
                .ForEach(textbox => { textbox.Clear(); });
            txtEquipo.Clear();
            txtFolio.Clear();
            txtObservaciones.Clear();
            cdtpFechaRecepcion.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar todos los campos
            Limpiar();
        }

        private void changeFocus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int Folio = int.Parse(txtFolio.Text);
            string Cliente = txtCliente.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            string Equipo = txtEquipo.Text;
            string Observaciones = txtObservaciones.Text;
            DateTime Recepcion = cdtpFechaRecepcion.Value;

            orden = new Orden(Folio, Cliente, Direccion, Telefono, Equipo, Observaciones, Recepcion);

            Console.WriteLine(orden.ToString());

            //Agregar a la base de datos
        }
    }
}
