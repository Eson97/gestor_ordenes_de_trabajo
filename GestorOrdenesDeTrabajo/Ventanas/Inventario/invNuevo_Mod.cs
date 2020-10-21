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

namespace GestorOrdenesDeTrabajo.Ventanas.Inventario
{
    public partial class invNuevo_Mod : Form
    {
        private Refaccion refaccion;
        private bool nuevo;
        public invNuevo_Mod()
        {
            InitializeComponent();
            nuevo = true;
        }

        public invNuevo_Mod(object refaccion)
        {
            InitializeComponent();
            this.refaccion = refaccion as Refaccion;
            nuevo = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                string code = txtCodigo.Text;
                string descripcion = txtDescripcion.Text;
                double minimo = double.Parse(txtPrecioMinimo.Text);
                refaccion = new Refaccion(-1, code, descripcion, minimo);
            }
            else
            {
                refaccion.Code = txtCodigo.Text;
                refaccion.Descripcion = txtDescripcion.Text;
                refaccion.Minimo = double.Parse(txtPrecioMinimo.Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void invNuevo_Mod_Load(object sender, EventArgs e)
        {
            if (!nuevo)
            {
                txtCodigo.Text = refaccion.Code;
                txtDescripcion.Text = refaccion.Descripcion;
                txtPrecioMinimo.Text = refaccion.Minimo.ToString();
            }
        }
    }
}
