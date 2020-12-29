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
        private Refaccion CurrentRefaccion;
        private RefaccionValidator Validator;

        public invNuevo_Mod()
        {
            InitializeComponent();
            Validator = new RefaccionValidator();
        }

        public invNuevo_Mod(Refaccion refaccion)
        {
            InitializeComponent();
            this.CurrentRefaccion = refaccion;
            Validator = new RefaccionValidator();
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

            if (CurrentRefaccion == null)
            {
                var toAdd = new Refaccion()
                {
                    Codigo = code,
                    Descripcion = descripcion,
                    PrecioMinimo = minimo,
                };

                var res = Validator.Validate(toAdd);
                if (ShowErrorValidation.Valid(res))
                    CurrentRefaccion = RefaccionController.I.Add(toAdd);

            }
            else
            {
                CurrentRefaccion.Codigo = code;
                CurrentRefaccion.Descripcion = descripcion;
                CurrentRefaccion.PrecioMinimo = minimo;

                var res = Validator.Validate(CurrentRefaccion);
                if (ShowErrorValidation.Valid(res))
                    CurrentRefaccion = RefaccionController.I.Edit(CurrentRefaccion);
            }

            if (CurrentRefaccion == null)
                MessageBox.Show("Error agregar o editar refaccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CurrentRefaccion = null;
            Helper.VaciarTexto(txtCodigo, txtDescripcion, txtPrecioMinimo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void invNuevo_Mod_Load(object sender, EventArgs e)
        {
            if (CurrentRefaccion != null)
            {
                txtCodigo.Text = CurrentRefaccion.Codigo;
                txtDescripcion.Text = CurrentRefaccion.Descripcion;
                txtPrecioMinimo.Text = CurrentRefaccion.PrecioMinimo.ToString();
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
