using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.Auxiliares;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
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
        static List<RefaccionDTO> res;
        private readonly Orden orden;
        private Refaccion current;
        private List<Refaccion> refacciones;

        public SelectRefaccionDialog(Orden o)
        {
            InitializeComponent();
            res = new List<RefaccionDTO>();
            this.orden = o;
            datatable = new DataTable();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Codigo");
            datatable.Columns.Add("Descripcion");
            datatable.Columns.Add("Precio Minimo");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            datatable.Columns[2].ReadOnly = true;
            datatable.Columns[3].ReadOnly = true;
            FillTable();
        }

        private void FillTable()
        {
            while (TablaRefacciones.RowCount != 0)
                TablaRefacciones.Rows.RemoveAt(0);

            refacciones = RefaccionController.I.GetLista().ToList();
            foreach (Refaccion item in refacciones)
                datatable.Rows.Add(new object[] { item.Id, item.Codigo, item.Descripcion, item.PrecioMinimo });

            TablaRefacciones.DataSource = datatable;
            TablaRefacciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TablaRefacciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TablaRefacciones.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TablaRefacciones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TablaRefacciones.Columns[0].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[1].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[2].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[3].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public static List<RefaccionDTO> showSRDialog(Orden o)
        {
            _Dialog = new SelectRefaccionDialog(o);
            _Dialog.ShowDialog();
            return res;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool isValid = Helper.Llenos(txtCant, txtCodigo, txtPrecio) && current != null;
            if (!isValid)
                return;

            int cantidad = int.Parse(txtCant.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);

            if (precio < current.PrecioMinimo)
            { MessageBox.Show("El precio es menor que el costo minimo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            res.Add(new RefaccionDTO()
            {
                Id = current.Id,
                Codigo = current.Codigo,
                Descripcion = current.Descripcion,
                Cantidad = cantidad,
                PrecioUnitrio = precio,
            });

            MessageDialog.ShowMessageDialog("", $"Se ha agregado la refaccion {current.Codigo} a la orden ", true);
            Helper.VaciarTexto(txtCant, txtCodigo, txtPrecio);
            current = null;
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
                datatable.DefaultView.RowFilter = $"Descripcion LIKE '%{txtFilter.Text}%'";
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = TablaRefacciones.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            string code = row.Cells[1].Value as string;
            string desc = row.Cells[2].Value as string;
            decimal minimo = decimal.Parse(row.Cells[3].Value as string);

            txtCodigo.Text = code;
            lblDesc.Text = desc;
            txtPrecio.Text = minimo.ToString();
            txtCant.Text = "1";

            current = new Refaccion
            {
                Id = id,
                Codigo = code,
                Descripcion = desc,
                PrecioMinimo = minimo,
            };
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string code = txtCodigo.Text;
                var s = refacciones.Where(el => el.Codigo.Equals(code)).FirstOrDefault();
                if (s == null)
                    return;

                txtCant.Text = "1";
                txtCodigo.Text = s.Codigo;
                lblDesc.Text = s.Descripcion;
                txtPrecio.Text = s.PrecioMinimo.ToString();
            }
        }
    }
}
