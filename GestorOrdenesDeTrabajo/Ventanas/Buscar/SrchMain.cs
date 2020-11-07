using BussinessLayer.Enum;
using BussinessLayer.UsesCases;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Buscar
{
    public partial class SrchMain : Form
    {
        DataTable datatable;
        DataGridViewCellStyle rowStyleCancelada;

        public SrchMain()
        {
            InitializeComponent();
            tablaOrdenes.CellBorderStyle = DataGridViewCellBorderStyle.None;

            datatable = new DataTable();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Folio");
            datatable.Columns.Add("Cliente");
            datatable.Columns.Add("Estado");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            datatable.Columns[2].ReadOnly = true;
            datatable.Columns[3].ReadOnly = true;

            rowStyleCancelada = new DataGridViewCellStyle();
            rowStyleCancelada.BackColor = Color.Red;
            rowStyleCancelada.ForeColor = Color.White;

            Actualizar();
        }

        void openSubPanel(Form Panel)
        {
            //Abre nueva ventana en el panel contenedor
            if (this.containerPanel.Controls.Count > 0)
                this.containerPanel.Controls.RemoveAt(0);
            Form newPanel = Panel as Form;
            newPanel.TopLevel = false;
            newPanel.Dock = DockStyle.Fill;
            this.containerPanel.Controls.Add(newPanel);
            this.containerPanel.Tag = newPanel;
            newPanel.Show();
        }

        void Actualizar()
        {
            if (tablaOrdenes.RowCount != 0)
                tablaOrdenes.Rows.Clear();
            
            var ordenes = OrdenController.I.GetLista();
            foreach (Orden item in ordenes)
                datatable.Rows.Add(item.Id, item.Folio, item.Cliente.Nombre, OrdenStatusManager.ToString(item.Status));

            tablaOrdenes.DataSource = datatable;

            tablaOrdenes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            tablaOrdenes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaOrdenes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaOrdenes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaOrdenes.Columns[0].Resizable = DataGridViewTriState.False;
            tablaOrdenes.Columns[1].Resizable = DataGridViewTriState.True;
            tablaOrdenes.Columns[2].Resizable = DataGridViewTriState.True;
            tablaOrdenes.Columns[3].Resizable = DataGridViewTriState.True;
            tablaOrdenes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaOrdenes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaOrdenes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void txtBuscarCodigo_Cliente_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCodigo_Cliente.Text != "Ingrese <Folio> o <Cliente> a buscar...")
                datatable.DefaultView.RowFilter = $"Folio LIKE '{txtBuscarCodigo_Cliente.Text}%' OR Cliente LIKE '{txtBuscarCodigo_Cliente.Text}%' ";

        }

        private void txtBuscarCodigo_Cliente_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCodigo_Cliente.Text == "Ingrese <Folio> o <Cliente> a buscar...")
            {
                txtBuscarCodigo_Cliente.ForeColor = Color.Black;
                txtBuscarCodigo_Cliente.Text = "";
            }
        }

        private void txtBuscarCodigo_Cliente_Leave(object sender, EventArgs e)
        {
            if (txtBuscarCodigo_Cliente.TextLength == 0)
            {
                txtBuscarCodigo_Cliente.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                txtBuscarCodigo_Cliente.Text = "Ingrese <Folio> o <Cliente> a buscar...";
            }
        }

        private void tablaOrdenes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in tablaOrdenes.Rows)
            {
                bool cancelada = row.Cells["Estado"].Value.ToString() == OrdenStatusManager.ToString((int)OrdenStatus.CANCELADA);
                if (cancelada)
                    row.DefaultCellStyle.BackColor = Color.Firebrick;
                else row.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            }
        }

        private void btnBuscarFolio_Click(object sender, EventArgs e)
        {
            if (txtSrchFolio.TextLength != 0)
            {
                int folio = int.Parse(txtSrchFolio.Text);
                var orden = OrdenController.I.SearchByFolio(folio);

                if (orden != null)
                {
                    var mecanicosByOrden = MecanicoController.I.searchMecanicosByOrden(orden.Id);
                    openSubPanel(new SrchDetailInfo(orden, mecanicosByOrden));
                }
                else
                { MessageBox.Show("No se encuentra la orden, revice el folio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtSrchFolio_Leave(object sender, EventArgs e)
        {
            if (txtSrchFolio.TextLength == 0)
            {
                txtSrchFolio.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                txtSrchFolio.Text = "Numero de Orden";
                btnBuscarFolio.Enabled = false;
            }
        }

        private void txtSrchFolio_Enter(object sender, EventArgs e)
        {
            if (txtSrchFolio.Text == "Numero de Orden")
            {
                txtSrchFolio.ForeColor = Color.Black;
                txtSrchFolio.Text = "";
                btnBuscarFolio.Enabled = true;
            }
        }

        private void txtSrchFolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarFolio_Click(this, new EventArgs());
            }
        }
    }
}
