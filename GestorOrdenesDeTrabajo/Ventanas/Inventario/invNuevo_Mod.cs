using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using GestorOrdenesDeTrabajo.Validation;
using System;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Inventario
{
    public partial class invNuevo_Mod : Form
    {
        private Refaccion refaccion;
        private RefaccionValidator v;

        public invNuevo_Mod()
        {
            InitializeComponent();
            v = new RefaccionValidator();
        }

        public invNuevo_Mod(Refaccion refaccion)
        {
            InitializeComponent();
            this.refaccion = refaccion;
            v = new RefaccionValidator();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Helper.Llenos(txtCodigo, txtDescripcion, txtPrecioMinimo);

            if (isEmpty)
            { MessageBox.Show("Llene todos los campos, por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            decimal minimo;

            string code = txtCodigo.Text;
            string descripcion = txtDescripcion.Text;
            bool parseIncorrect = !decimal.TryParse(txtPrecioMinimo.Text, out minimo);

            if (parseIncorrect)
            { MessageBox.Show("El precio no es valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            minimo = Math.Round(minimo, 2);

            if (refaccion == null)
            {
                var toAdd = new Refaccion()
                {
                    Codigo = code,
                    Descripcion = descripcion,
                    PrecioMinimo = minimo,
                };

                var res = v.Validate(toAdd);
                if (ShowErrorValidation.Valid(res))
                    refaccion = RefaccionController.I.Add(toAdd);

            }
            else
            {
                refaccion.Codigo = code;
                refaccion.Descripcion = descripcion;
                refaccion.PrecioMinimo = minimo;

                var res = v.Validate(refaccion);
                if (ShowErrorValidation.Valid(res))
                    refaccion = RefaccionController.I.Edit(refaccion);
            }

            if (refaccion == null)
                MessageBox.Show("Error agregar o editar refaccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            refaccion = null;
            Helper.VaciarTexto(txtCodigo, txtDescripcion, txtPrecioMinimo);
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
            Filtro.NumerosDecimales(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoComaPuntoGuion(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoSpaceComaPuntoGuion(e);
            if (e.KeyChar == (char)Keys.Enter) btnAceptar_Click(sender, e);
        }
    }
}
