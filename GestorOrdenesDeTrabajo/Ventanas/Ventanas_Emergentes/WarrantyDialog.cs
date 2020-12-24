using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

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
        private List<Orden> ordenes;
        public WarrantyDialog()
        {
            InitializeComponent();
            datatable = new DataTable();
            ordenes = new List<Orden>();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Folio");
            datatable.Columns.Add("Cliente");
            datatable.Columns.Add("Maquina");
            datatable.Columns.Add("Entregado");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            datatable.Columns[2].ReadOnly = true;
            datatable.Columns[3].ReadOnly = true;
            datatable.Columns[4].ReadOnly = true;
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
            while (tablaOrdenes.RowCount != 0)
                tablaOrdenes.Rows.RemoveAt(0);

            ordenes = OrdenController.I.GetLista((int)OrdenStatus.ENTREGADA);
            foreach (Orden item in ordenes)
            {
                datatable.Rows.Add(new object[] { item.Id, item.Folio, item.Cliente.Nombre, item.Equipo, item.FechaEntrega });
            }

            tablaOrdenes.DataSource = datatable;
            tablaOrdenes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            tablaOrdenes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaOrdenes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaOrdenes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            tablaOrdenes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            tablaOrdenes.Columns[0].Resizable = DataGridViewTriState.True;
            tablaOrdenes.Columns[1].Resizable = DataGridViewTriState.True;
            tablaOrdenes.Columns[2].Resizable = DataGridViewTriState.True;
            tablaOrdenes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _currentOrder = null;
            this.Dispose();
        }

        private void tablaOrdenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1)
                return;

            DataGridViewRow row = tablaOrdenes.CurrentRow;
            int id = int.Parse(row.Cells[0].Value as string);
            int folio = int.Parse(row.Cells[1].Value.ToString());
            string cliente = row.Cells[2].Value as string;
            string maquina = row.Cells[3].Value as string;
            string fecha = row.Cells[4].Value as string;


            txtFolio.Text = folio.ToString();
            lblCliente.Text = cliente;
            lblFechaEntrega.Text = fecha;
            lblMaquina.Text = maquina;

            _currentOrder = new Orden()
            {
                Id = id,
                Folio = folio,
            };
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var filtro = txtFilter.Text;
            var tempOrdenes = ordenes.Where(el => el.Folio.ToString().Contains(filtro)).ToList();

            while (tablaOrdenes.RowCount != 0)
                tablaOrdenes.Rows.RemoveAt(0);

            foreach (Orden item in tempOrdenes)
            {
                datatable.Rows.Add(new object[] { item.Id, item.Folio, item.Cliente.Nombre, item.Equipo, item.FechaEntrega });
            }
        }
    }
}
