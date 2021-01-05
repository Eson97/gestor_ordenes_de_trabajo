using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using GestorOrdenesDeTrabajo.Ventanas.Inventario;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.OrdenWindow.Inventario
{
    public partial class InvMain : Form
    {
        DataTable Datatable;
        private bool canEdit = true;
        private Excel.ExcelController xlsx = new Excel.ExcelController();
        List<Refaccion> refacciones;
        public InvMain()
        {
            InitializeComponent();
            InitPermisos();

            tablaInventario.CellBorderStyle = DataGridViewCellBorderStyle.None;

            //Datatable = new DataTable();
            //Datatable.Columns.Add("ID");
            //Datatable.Columns.Add("Codigo");
            //Datatable.Columns.Add("Pieza");
            //Datatable.Columns.Add("Precio Minimo");
            //Datatable.Columns[0].ReadOnly = true;
            //Datatable.Columns[1].ReadOnly = true;
            //Datatable.Columns[2].ReadOnly = true;
            //Datatable.Columns[3].ReadOnly = true;
            //Datatable.Columns[3].DataType = typeof(decimal);
            ActualizarAsync();
        }

        private void InitPermisos()
        {
            if (CurrentUser.User == null)
                return;
            //permisos = await Task.Run(() => UsuarioPermisoController.I.GetListaPermisoByUsuario(currentUser.Id));
            Permission(CurrentUser.Permisos);
        }

        private void DeniedPermission(params Control[] control)
        {
            canEdit = false;

            foreach (Control c in control)
            {
                c.Enabled = false;
            }
        }
        private object CanEdit()
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            canEdit = true;
            return default;
        }

        private void Permission(IList<Permiso> permisos)
        {
            Button[] buttons = { btnNuevo, btnModificar, btnEliminar, btnImportar, btnExportar };

            DeniedPermission(buttons);

            if (permisos != null)
            {
                int a = (int)Permisos.INVENTARIO;
                Console.WriteLine(a.ToString());
                foreach (Permiso item in permisos)
                {
                    object p = item.Id switch
                    {
                        (int)Permisos.MOD_INVENTARIO => CanEdit(),
                        (int)Permisos.EXP_INVENTARIO => btnImportar.Enabled = true,
                        (int)Permisos.IMP_INVENTARIO => btnExportar.Enabled = true,
                        _ => -1
                    };
                    _ = p;

                }
            }
        }

        public async void ActualizarAsync()
        {
            //while (tablaInventario.RowCount != 0)
            //    tablaInventario.Rows.RemoveAt(0);

            refacciones = await Task.Run(() => RefaccionController.I.GetLista());

            //foreach (Refaccion item in refacciones)
            //    Datatable.Rows.Add(new object[] { item.Id, item.Codigo, item.Descripcion, item.PrecioMinimo });

            tablaInventario.DataSource = refacciones.Select(el => new
            {
                Id = el.Id,
                Codigo = el.Codigo,
                Descripcion = el.Descripcion,
                PrecioMinimo = el.PrecioMinimo
            }).ToList();
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
                int id = int.Parse(row.Cells[0].Value.ToString());
                string code = row.Cells[1].Value.ToString();
                string pieza = row.Cells[2].Value.ToString();
                double minimo = double.Parse(row.Cells[3].Value.ToString());

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
                int id = int.Parse(row.Cells[0].Value.ToString());
                string pieza = row.Cells[2].Value.ToString();

                if ((int)MessageDialogResult.Yes == MessageDialog.ShowMessageDialog("Eliminar", $"¿Esta seguro de que desea eliminar '{pieza}' del inventario?", false))
                {
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
            if ((int)MessageDialogResult.Yes == MessageDialog.ShowMessageDialog("Confirmacion", "¿Desea importar refacciones desde un excel?\nEsto puede tardar unos minutos", false))
            {

                using (var file = new OpenFileDialog { Filter = @"Excel files (*.xls or .xlsx)|.xls;*.xls", Multiselect = false })
                {
                    if (file.ShowDialog() == DialogResult.OK)
                        xlsx.ImportExcelFrom(file.FileName);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if ((int)MessageDialogResult.Yes == MessageDialog.ShowMessageDialog("Confirmacion", "¿Desea exportar las refacciones a un excel?\nEsto puede tardar unos minutos", false))
            {
                xlsx.CreateExcelRefacciones(refacciones);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarAsync();
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            if (refacciones == null)
                return;

            if (txtBuscarCodigo.Text != "Ingrese <Codigo> o <Pieza> a buscar...")
                tablaInventario.DataSource = refacciones.Where(el => el.Codigo.Contains(txtBuscarCodigo.Text)).Select(el => new
                {
                    Id = el.Id,
                    Codigo = el.Codigo,
                    Descripcion = el.Descripcion,
                    PrecioMinimo = el.PrecioMinimo
                }).ToList();
            //Datatable.DefaultView.RowFilter = $"Codigo LIKE '{txtBuscarCodigo.Text}%' OR Pieza LIKE '{txtBuscarCodigo.Text}%' ";
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
            if (!canEdit) return;

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = tablaInventario.CurrentRow;
                int id = int.Parse(row.Cells[0].Value.ToString());
                string code = row.Cells[1].Value.ToString();
                string pieza = row.Cells[2].Value.ToString();
                double minimo = double.Parse(row.Cells[3].Value.ToString());

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

        private void tablaInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaInventario.Columns[e.ColumnIndex].Name == "Precio Minimo")
                tablaInventario.Columns[e.ColumnIndex].DefaultCellStyle.Format = "C2"; //asigna formato moneda con 2 decimales
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoSpaceComaPuntoGuion(e);
        }
    }
}
