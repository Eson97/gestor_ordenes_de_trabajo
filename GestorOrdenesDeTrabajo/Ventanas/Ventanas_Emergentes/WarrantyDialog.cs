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

        DataTable DataTable;
        private static Orden CurrentOrden;
        private static WarrantyDialog Dialog;
        private List<Orden> Ordenes;
        public WarrantyDialog()
        {
            InitializeComponent();
            DataTable = new DataTable();
            Ordenes = new List<Orden>();
            DataTable.Columns.Add("ID");
            DataTable.Columns.Add("Folio");
            DataTable.Columns.Add("Cliente");
            DataTable.Columns.Add("Maquina");
            DataTable.Columns.Add("Entregado");
            DataTable.Columns[0].ReadOnly = true;
            DataTable.Columns[1].ReadOnly = true;
            DataTable.Columns[2].ReadOnly = true;
            DataTable.Columns[3].ReadOnly = true;
            DataTable.Columns[4].ReadOnly = true;
            FillTable();

            CurrentOrden = null;

        }

        public static Orden showWarrantyDialog()
        {
            Dialog = new WarrantyDialog();
            Dialog.ShowDialog();

            return CurrentOrden;
        }

        private void FillTable()
        {
            while (tablaOrdenes.RowCount != 0)
                tablaOrdenes.Rows.RemoveAt(0);

            Ordenes = OrdenController.I.GetLista((int)OrdenStatus.ENTREGADA);
            foreach (Orden item in Ordenes)
            {
                DataTable.Rows.Add(new object[] { item.Id, item.Folio, item.Cliente.Nombre, item.Equipo, item.FechaEntrega });
            }

            tablaOrdenes.DataSource = DataTable;
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
            CurrentOrden = null;
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

            CurrentOrden = new Orden()
            {
                Id = id,
                Folio = folio,
            };
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var filtro = txtFilter.Text;

            if (filtro.Length == 0 || filtro.Equals("Ingrese Folio de la orden"))
                return;

            var tempOrdenes = Ordenes.Where(el => el.Folio.ToString().Contains(filtro)).ToList();

            while (tablaOrdenes.RowCount != 0)
                tablaOrdenes.Rows.RemoveAt(0);

            foreach (Orden item in tempOrdenes)
            {
                DataTable.Rows.Add(new object[] { item.Id, item.Folio, item.Cliente.Nombre, item.Equipo, item.FechaEntrega });
            }
        }
    }
}
