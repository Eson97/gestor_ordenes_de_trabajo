using BussinessLayer.UsesCases;
using DataLayer;
using System;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Inventario
{
    public partial class invNuevo_Mod : Form
    {
        private readonly bool nuevo;
        private Refaccion refaccion;
        public invNuevo_Mod()
        {
            InitializeComponent();
            nuevo = true;
        }

        public invNuevo_Mod(Refaccion refaccion)
        {
            InitializeComponent();
            this.refaccion = refaccion;
            nuevo = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //TODO agregar validaciones al agregar y editar, decimal no soporta 3 decimales en la DB, truncar o formatear
            if (nuevo)
            {
                string code = txtCodigo.Text;
                string descripcion = txtDescripcion.Text;
                decimal minimo = decimal.Parse(txtPrecioMinimo.Text);
                refaccion = RefaccionController.I.Add(new Refaccion()
                {
                    Codigo = code,
                    Descripcion = descripcion,
                    PrecioMinimo = minimo,
                });
            }
            else
            {
                //Excepcion al editar por segunda vez ->Limpiar valores despues de agregar o editar
                refaccion.Codigo = txtCodigo.Text;
                refaccion.Descripcion = txtDescripcion.Text;
                refaccion.PrecioMinimo = decimal.Parse(txtPrecioMinimo.Text);

                refaccion = RefaccionController.I.Edit(refaccion);
            }

            //TODO agregar mensaje de confirmacion?
            if (refaccion == null)
                MessageBox.Show("Codigo de refaccion repetido, introduzca otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void invNuevo_Mod_Load(object sender, EventArgs e)
        {
            if (!nuevo)
            {
                txtCodigo.Text = refaccion.Codigo;
                txtDescripcion.Text = refaccion.Descripcion;
                txtPrecioMinimo.Text = refaccion.PrecioMinimo.ToString();
            }
        }
    }
}
