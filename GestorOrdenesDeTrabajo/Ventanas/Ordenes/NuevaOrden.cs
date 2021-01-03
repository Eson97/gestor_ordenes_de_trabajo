using System;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using GestorOrdenesDeTrabajo.Validation;
using GestorOrdenesDeTrabajo.Ventanas.Message;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class NuevaOrden : Form
    {
        Cliente cliente;
        private OrdenValidator OrdenValidator;
        private OrdenHistorialValidator OrdenHistorialValidator;

        public NuevaOrden()
        {
            InitializeComponent();
            OrdenValidator = new OrdenValidator();
            OrdenHistorialValidator = new OrdenHistorialValidator();

        }

        void Limpiar()
        {
            Helper.VaciarTexto(txtEquipo, txtFolio, txtObservaciones, txtCliente, txtDireccion, txtTelefono);
            cdtpFechaRecepcion.Value = DateTime.Now;
        }

        void fillData(Cliente c)
        {
            if (c != null)
            {
                txtCliente.Text = c.Nombre;
                txtDireccion.Text = c.Direccion;
                txtTelefono.Text = c.Telefono;
            }
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
            bool isEmpty = !Helper.Llenos(txtEquipo, txtObservaciones, txtFolio);
            if (cliente == null || isEmpty)
                return;

            int folio = int.Parse(txtFolio.Text);
            string equipo = txtEquipo.Text;
            string observaciones = txtObservaciones.Text;
            DateTime recepcion = cdtpFechaRecepcion.Value;

            var orden = new Orden()
            {
                Folio = folio,
                Equipo = equipo,
                FechaRecepcion = recepcion,
                Observaciones = observaciones,
                Status = (int)OrdenStatus.ESPERA,
                IdCliente = cliente.Id
            };

            var res = OrdenValidator.Validate(orden);

            if (ShowErrorValidation.Valid(res))
                orden = OrdenController.I.Add(orden);


            if (orden == null)
            { MessageBox.Show("Error al agregar a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            //Agrega el estado de la orden al historial
            var ordenHistorial = new OrdenHistorial()
            {
                IdOrden = orden.Id,
                FechaStatus = DateTime.Now,
                Status = (int)OrdenStatus.ESPERA
            };

            res = OrdenHistorialValidator.Validate(ordenHistorial);
            if (ShowErrorValidation.Valid(res))
            {
                var saved = OrdenHistorialController.I.Add(ordenHistorial);
                if (saved == null)
                    MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (orden != null)
            {
                Helper.VaciarTexto(txtFolio, txtEquipo, txtObservaciones, txtTelefono, txtDireccion, txtCliente);
                Console.WriteLine(orden.ToString());
                orden = null;
                cliente = null;
                ordenHistorial = null;
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                cliente = ClienteDialog.showClientDialog();
                fillData(cliente);
            }
        }

        private void btnSrchCliente_Click(object sender, EventArgs e)
        {
            cliente = ClienteDialog.showClientDialog();
            fillData(cliente);
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.Numeros(e);
        }

        private void txtEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoSpaceComaPunto(e);
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoSpaceComaPunto(e);
        }
    }
}
