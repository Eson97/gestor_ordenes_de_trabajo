﻿using BussinessLayer.Enum;
using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.Ventanas.Inventario;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.OrdenWindow.Inventario
{
    public partial class InvMain : Form
    {
        DataTable datatable;
        public InvMain()
        {
            InitializeComponent();

            tablaInventario.CellBorderStyle = DataGridViewCellBorderStyle.None;

            datatable = new DataTable();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Codigo");
            datatable.Columns.Add("Pieza");
            datatable.Columns.Add("Precio Minimo");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = true;
            datatable.Columns[2].ReadOnly = true;
            datatable.Columns[3].ReadOnly = true;
            Actualizar();
        }

        public void Actualizar()
        {
            while (tablaInventario.RowCount != 0)
                tablaInventario.Rows.RemoveAt(0);

            var refacciones = RefaccionController.I.GetLista();
            foreach (Refaccion item in refacciones)
                datatable.Rows.Add(new object[] { item.Id, item.Codigo, item.Descripcion, item.PrecioMinimo });

            tablaInventario.DataSource = datatable;
            tablaInventario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            tablaInventario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaInventario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaInventario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaInventario.Columns[0].Resizable = DataGridViewTriState.False;
            tablaInventario.Columns[1].Resizable = DataGridViewTriState.True;
            tablaInventario.Columns[2].Resizable = DataGridViewTriState.True;
            tablaInventario.Columns[3].Resizable = DataGridViewTriState.True;
            tablaInventario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        void openSubPanel(Form Panel, string Tittle)
        {
            lblActionTittle.Text = Tittle;

            //Abre nueva ventana en el panel contenedor
            if (this.subPanel.Controls.Count > 0)
                this.subPanel.Controls.RemoveAt(0);
            Form newPanel = Panel as Form;
            newPanel.TopLevel = false;
            newPanel.Dock = DockStyle.Fill;
            this.subPanel.Controls.Add(newPanel);
            this.subPanel.Tag = newPanel;
            newPanel.Show();
        }

        private void subPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.lblActionTittle.Hide();
        }

        private void subPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            lblActionTittle.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            openSubPanel(new invNuevo_Mod(), "Agregar Nueva Refaccion");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tablaInventario.RowCount <= 0) return;
            if (tablaInventario.CurrentRow.Index != -1)
            {
                DataGridViewRow row = tablaInventario.CurrentRow;
                int id = int.Parse(row.Cells[0].Value as string);
                string code = row.Cells[1].Value as string;
                string pieza = row.Cells[2].Value as string;
                double minimo = double.Parse(row.Cells[3].Value as string);

                Refaccion toEdit = new Refaccion()
                {
                    Id = id,
                    Codigo = code,
                    Descripcion = pieza,
                    PrecioMinimo = (decimal)minimo
                };

                openSubPanel(new invNuevo_Mod(toEdit), "Modificar Refaccion");
            }
            else
                MessageBox.Show("Seleccione una refaccion en la tabla y vuelva a intentar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaInventario.CurrentRow.Index != -1)
            {
                DataGridViewRow row = tablaInventario.CurrentRow;
                int id = int.Parse(row.Cells[0].Value as string);
                string code = row.Cells[1].Value as string;
                string pieza = row.Cells[2].Value as string;
                double minimo = double.Parse(row.Cells[3].Value as string);
                if ((int)MessageDialogResult.Yes == MessageDialog.ShowMessageDialog("Eliminar", $"¿Esta seguro de que desea eliminar '{pieza}' del inventario?", false))
                {
                    //TODO agregar comprobacion de OrdenRefaccion is empty eliminar definitivo
                    bool deleted = RefaccionController.I.Delete(id);
                    if (deleted)
                        MessageBox.Show("Eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se encontro el elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Cierra el panel en caso de estar abierto
                    if (this.subPanel.Controls.Count > 0)
                        this.subPanel.Controls.RemoveAt(0);
                }
                else Console.WriteLine("No se va a borrar");
            }
            else
                MessageBox.Show("Seleccione una refaccion en la tabla y vuelva a intentar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openSubPanel(this, "Importar Desde Excel");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            openSubPanel(this, "Exportar Desde Excel");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCodigo.Text != "Ingrese <Codigo> o <Pieza> a buscar...")
                datatable.DefaultView.RowFilter = $"Codigo LIKE '{txtBuscarCodigo.Text}%' OR Pieza LIKE '{txtBuscarCodigo.Text}%' ";
        }

        private void txtBuscarCodigo_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCodigo.Text == "Ingrese <Codigo> o <Pieza> a buscar...")
            {
                txtBuscarCodigo.ForeColor = Color.Black;
                txtBuscarCodigo.Text = "";
            }
        }

        private void txtBuscarCodigo_Leave(object sender, EventArgs e)
        {
            if (txtBuscarCodigo.TextLength == 0)
            {
                txtBuscarCodigo.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                txtBuscarCodigo.Text = "Ingrese <Codigo> o <Pieza> a buscar...";
            }
        }

        private void tablaInventario_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Se dio doble click :D");
            //TODO añadir validacion para permiso de usuario
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = tablaInventario.CurrentRow;
                int id = int.Parse(row.Cells[0].Value as string);
                string code = row.Cells[1].Value as string;
                string pieza = row.Cells[2].Value as string;
                double minimo = double.Parse(row.Cells[3].Value as string);

                Refaccion toEdit = new Refaccion()
                {
                    Id = id,
                    Codigo = code,
                    Descripcion = pieza,
                    PrecioMinimo = (decimal)minimo
                };

                openSubPanel(new invNuevo_Mod(toEdit), "Modificar Refaccion");
            }
        }
    }
}
