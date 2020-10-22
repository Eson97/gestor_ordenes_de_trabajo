using System;
using System.Linq;
using System.Windows.Forms;
using BussinessLayer.Enum;
using BussinessLayer.UsesCases;
using DataLayer;

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
            int folio = int.Parse(txtFolio.Text);
            string nombreCliente = txtCliente.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string equipo = txtEquipo.Text;
            string observaciones = txtObservaciones.Text;
            DateTime recepcion = cdtpFechaRecepcion.Value;

            var cliente = ClienteController.I.Add(new Cliente()
            {
                Nombre = nombreCliente,
                Direccion = direccion,
                Telefono = telefono,
            });

            var orden = OrdenController.I.Add(new Orden()
            {
                Folio = folio,
                Equipo = equipo,
                FechaRecepcion = recepcion,
                Observaciones = observaciones,
                Status = (int)OrdenStatus.ESPERA,
                Cliente = cliente,
                IdCliente = cliente.Id,
            });


            Console.WriteLine(orden.ToString());
            //TODO revisar consulta
        }
    }
}
