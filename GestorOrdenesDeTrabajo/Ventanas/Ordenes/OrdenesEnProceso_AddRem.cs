using GestorOrdenesDeTrabajo.Auxiliares;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enum;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnProceso_AddRem : Form
    {
        Orden Orden;
        DataTable DataTable;
        List<RefaccionDTO> Refacciones;
        bool CambiosGuardados = true;

        public OrdenesEnProceso_AddRem(Orden orden)
        {
            InitializeComponent();
            DataTable = new DataTable();
            DataTable.Columns.Add("ID");
            DataTable.Columns.Add("Codigo");
            DataTable.Columns.Add("Descripcion");
            DataTable.Columns.Add("Cant");
            DataTable.Columns.Add("P/U");
            DataTable.Columns[0].ReadOnly = true;
            DataTable.Columns[1].ReadOnly = false;
            DataTable.Columns[2].ReadOnly = false;
            DataTable.Columns[3].ReadOnly = false;
            DataTable.Columns[4].ReadOnly = false;
            DataTable.Columns[4].DataType = typeof(decimal);

            this.Orden = orden;
            Refacciones = new List<RefaccionDTO>();

            if (orden == null)
                return;

            this.lblCliente.Text = Orden.Cliente.Nombre;
            this.lblEquipo.Text = Orden.Equipo;
            this.lblFolio.Text = Orden.Folio.ToString();

            getPiecesInWorkOrder();
        }

        void getPiecesInWorkOrder()
        {
            while (tablaRefacciones.RowCount != 0)
                tablaRefacciones.Rows.RemoveAt(0);

            Refacciones = OrdenRefaccionController.I.GetListaByOrden(Orden.Id);
            foreach (RefaccionDTO item in Refacciones)
                DataTable.Rows.Add(new object[] { item.Id, item.Codigo, item.Descripcion, item.Cantidad, item.PrecioUnitrio });

            tablaRefacciones.DataSource = DataTable;
            tablaRefacciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            tablaRefacciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaRefacciones.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaRefacciones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            tablaRefacciones.Columns[0].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[1].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[2].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaRefacciones.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        void UpdatePiecesInWorkOrder()
        {
            //Elimina todos los registros de la orden
            bool deleted = OrdenRefaccionController.I.DeleteRange(Orden.Id);
            if (!deleted)
                MessageBox.Show("Ocurrio un error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Agrega los registros nuevos
            foreach (DataGridViewRow row in tablaRefacciones.Rows)
            {
                int id = int.Parse(row.Cells[0].Value as string);
                int cantidad = int.Parse(row.Cells[3].Value as string);
                var algo = row.Cells[4].Value.ToString();
                decimal precio = decimal.Parse(algo);

                OrdenRefaccionController.I.Add(new OrdenRefaccion
                {
                    IdOrden = Orden.Id,
                    IdRefaccion = id,
                    Cantidad = cantidad,
                    PrecioUnitario = precio,
                });
            }
            CambiosGuardados = true;
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            if (!CambiosGuardados)// si no se han guardado cambios: se pide confirmacion antes de cerrar
            {
                if (MessageDialog.ShowMessageDialog("Confirmacion", "¿Desea guardar cambios antes de cerrar?", false) == (int)MessageDialogResult.Yes)
                    UpdatePiecesInWorkOrder();

                this.Dispose();
            }

            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CambiosGuardados)// si no se han guardado cambios se guardan y cambia estado
            {
                UpdatePiecesInWorkOrder();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Refacciones.AddRange(SelectRefaccionDialog.showSRDialog(Orden));

            //agrupa piezas repetidas y suma la cantidad de piezas usadas >>En caso de haber diferencia en P/u tomar el valor mas alto
            Refacciones = Refacciones
                .GroupBy(el => el.Id)
                .Select(ele => new RefaccionDTO
                {
                    Id = ele.Key,
                    Codigo = ele.FirstOrDefault().Codigo,
                    Descripcion = ele.FirstOrDefault().Descripcion,
                    Cantidad = ele.Sum(i => i.Cantidad),
                    PrecioUnitrio = ele.Max(i => i.PrecioUnitrio),

                }).ToList();

            while (tablaRefacciones.RowCount != 0)
                tablaRefacciones.Rows.RemoveAt(0);

            foreach (RefaccionDTO item in Refacciones)
                DataTable.Rows.Add(new object[] { item.Id, item.Codigo, item.Descripcion, item.Cantidad, item.PrecioUnitrio });

            if (CambiosGuardados)
                CambiosGuardados = false;
        }

        //Elimina la pieza de la tabla
        private void btnRem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = tablaRefacciones.CurrentRow;
            if (row != null && tablaRefacciones.CurrentRow.Index != -1)
            {
                bool delete = (int)MessageDialogResult.Yes == MessageDialog.ShowMessageDialog("Eliminar", $"¿Esta seguro de que desea eliminar la pieza?", false);
                if (delete)
                {
                    tablaRefacciones.Rows.Remove(row);
                }
                else Console.WriteLine("No se va a borrar");
            }
            else
                MessageBox.Show("Seleccione una refaccion en la tabla y vuelva a intentar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (CambiosGuardados)
                CambiosGuardados = false;
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            Orden.Status = (int)OrdenStatus.POR_ENTREGAR;
            Orden = OrdenController.I.Edit(Orden);
            if (Orden == null)
                MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Orden.Status = (int)OrdenStatus.CANCELADA;
            Orden = OrdenController.I.Edit(Orden);
            if (Orden == null)
                MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Agregar codigo para cambiar cantidades

            //REMOVER BOTON?

            //CAMBIAR FUNCIONAMIENTO PARA DAR UN VALOR APROXIMADO?

            if (CambiosGuardados)
                CambiosGuardados = false;
        }

        private void tablaRefacciones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            //Actualizar lista con los nuevos valores?

            if (CambiosGuardados)
                CambiosGuardados = false;
        }

        private void tablaRefacciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaRefacciones.Columns[e.ColumnIndex].Name == "P/U")
                tablaRefacciones.Columns[e.ColumnIndex].DefaultCellStyle.Format = "C2"; //asigna formato moneda con 2 decimales
        }
    }
}
