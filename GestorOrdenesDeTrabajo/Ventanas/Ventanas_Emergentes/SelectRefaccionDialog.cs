using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Ventanas.Message;

namespace GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes
{
    public partial class SelectRefaccionDialog : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable datatable;
        static SelectRefaccionDialog _Dialog;
        static List<OrdenRefaccion> _DialogResult;
        private readonly Orden orden;

        public SelectRefaccionDialog(Orden o)
        {
            InitializeComponent();
            _DialogResult = new List<OrdenRefaccion>();
            this.orden = o;
            datatable = new DataTable();
            datatable.Columns.Add("Codigo");
            datatable.Columns.Add("Descripcion");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            FillTable();
        }

        private void FillTable()
        {
            //Add code


            TablaRefacciones.DataSource = datatable;
            TablaRefacciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TablaRefacciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TablaRefacciones.Columns[0].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[1].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public static List<OrdenRefaccion> showSRDialog(Orden o)
        {
            _Dialog = new SelectRefaccionDialog(o);
            _Dialog.ShowDialog();
            return _DialogResult;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //TODO agregar Refaccion a la lista y validar
            string codigo = txtCodigo.Text;
            int cantidad = int.Parse(txtCant.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);



            //_DialogResult.Add(item)

            MessageDialog.ShowMessageDialog("", $"Se ha agregado la refaccion {codigo} a la orden {orden.Folio}", true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Ingrese el codigo o el nombre de la pieza")
            {
                txtFilter.ForeColor = Color.Black;
                txtFilter.Text = "";
            }
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            if (txtFilter.TextLength == 0)
            {
                txtFilter.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                txtFilter.Text = "Ingrese el codigo o el nombre de la pieza";
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text != "Ingrese el codigo o el nombre de la pieza")
                datatable.DefaultView.RowFilter = $"Nombre LIKE '%{txtFilter.Text}%'";
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = TablaRefacciones.CurrentRow;
            string code = row.Cells[0].Value as string;
            string desc = row.Cells[1].Value as string;

            txtCodigo.Text = code;
            lblDesc.Text = desc;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //Get Item if exist and fill data
            }
        }
    }
}
