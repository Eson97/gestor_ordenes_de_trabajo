using GestorOrdenesDeTrabajo.DB;
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

namespace GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes
{
    public partial class WarrantyDialog : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        DataTable datatable;
        private static Orden _currentOrder;
        private static WarrantyDialog _WR;

        public WarrantyDialog()
        {
            InitializeComponent();
            datatable = new DataTable();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Folio");
            datatable.Columns.Add("Cliente");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            datatable.Columns[2].ReadOnly = true;
            FillTable();

            _currentOrder = null;

        }

        public static Orden showWarrantyDialog()
        {
            _WR = new WarrantyDialog();
            _WR.ShowDialog();

            return _currentOrder;
        }

        private void FillTable()
        {
            while (TablaRefacciones.RowCount != 0)
                TablaRefacciones.Rows.RemoveAt(0);

            //refacciones = RefaccionController.I.GetLista().ToList();
            //foreach (Refaccion item in refacciones)
            //    datatable.Rows.Add(new object[] { item.Id, item.Codigo, item.Descripcion, item.PrecioMinimo });

            TablaRefacciones.DataSource = datatable;
            TablaRefacciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TablaRefacciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TablaRefacciones.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TablaRefacciones.Columns[0].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[1].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[2].Resizable = DataGridViewTriState.True;
            TablaRefacciones.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            if (txtFilter.Text == "Ingrese Folio de la orden")
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
                txtFilter.Text = "Ingrese Folio de la orden";
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGarantia_Click(object sender, EventArgs e)
        {
            //Obtener la orden seleccionada

            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _currentOrder = null;
            this.Dispose();
        }
    }
}
