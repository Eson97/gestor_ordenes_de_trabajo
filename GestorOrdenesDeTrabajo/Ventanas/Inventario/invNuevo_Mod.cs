using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using System;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Inventario
{
    public partial class invNuevo_Mod : Form
    {
        private Refaccion refaccion;
        public invNuevo_Mod()
        {
            InitializeComponent();
        }

        /**FIXME
         * DESCRIPCION Y CODIGO DEBE DE ACEPTAR TAMBIEN CARACTERES ESPECIALES COMO '-' , '(' , ')' Y CREO QUE NOMAS
         * PRECIO MINIMO DEBE DE ACEPTAR TAMBIEN '.'
         */

        public invNuevo_Mod(Refaccion refaccion)
        {
            InitializeComponent();
            this.refaccion = refaccion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Helper.Llenos(txtCodigo, txtDescripcion, txtPrecioMinimo))
            { MessageBox.Show("Llene todos los campos, por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string code = txtCodigo.Text;
            string descripcion = txtDescripcion.Text;
            decimal minimo = decimal.Parse(txtPrecioMinimo.Text);

            minimo = Math.Round(minimo, 2);

            Helper.VaciarTexto(txtCodigo, txtDescripcion, txtPrecioMinimo);

            if (refaccion == null)
            {
                refaccion = RefaccionController.I.Add(new Refaccion()
                {
                    Codigo = code,
                    Descripcion = descripcion,
                    PrecioMinimo = minimo,
                });
            }
            else
            {
                refaccion.Codigo = code;
                refaccion.Descripcion = descripcion;
                refaccion.PrecioMinimo = minimo;
                refaccion = RefaccionController.I.Edit(refaccion);
            }

            //TODO agregar mensaje de confirmacion?
            if (refaccion == null)
                MessageBox.Show("Codigo de refaccion repetido, introduzca otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            refaccion = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void invNuevo_Mod_Load(object sender, EventArgs e)
        {
            if (refaccion != null)
            {
                txtCodigo.Text = refaccion.Codigo;
                txtDescripcion.Text = refaccion.Descripcion;
                txtPrecioMinimo.Text = refaccion.PrecioMinimo.ToString();
            }
        }

        private void txtPrecioMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.SoloNumeros(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.Alfanumerico(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoSpaceComaPunto(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }
    }
}
