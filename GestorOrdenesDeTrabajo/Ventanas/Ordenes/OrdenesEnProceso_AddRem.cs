using GestorOrdenesDeTrabajo.Auxiliares;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnProceso_AddRem : Form
    {
        Orden Orden;
        DataTable DataTable;
        List<RefaccionDTO> Refacciones;
        OrdenStatus Estado;
        bool CambiosGuardados = true;

        public OrdenesEnProceso_AddRem(Orden orden, OrdenStatus Estado)
        {
            InitializeComponent();
            this.Estado = Estado;
            DataTable = new DataTable();
            DataTable.Columns.Add("ID");
            DataTable.Columns.Add("Codigo");
            DataTable.Columns.Add("Descripcion");
            DataTable.Columns.Add("Cant");
            DataTable.Columns.Add("P/U");
            DataTable.Columns[0].ReadOnly = true;
            DataTable.Columns[1].ReadOnly = true;
            DataTable.Columns[2].ReadOnly = true;
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

            Refacciones = Estado switch
            {
                OrdenStatus.PROCESO => OrdenRefaccionController.I.GetListaByOrden(Orden.Id),
                OrdenStatus.GARANTIA => OrdenRefaccionGarantiaController.I.GetListaByOrden(Orden.Id),
                _ => new List<RefaccionDTO>()
            };


            foreach (RefaccionDTO item in Refacciones)
                DataTable.Rows.Add(new object[] { item.Id, item.Codigo, item.Descripcion, item.Cantidad, item.PrecioUnitrio });

            tablaRefacciones.DataSource = DataTable;
            tablaRefacciones.Columns[0].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[1].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[2].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaRefacciones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaRefacciones.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaRefacciones.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        void UpdatePiecesInWorkOrder()
        {
            //Elimina todos los registros de la orden
            bool deleted = Estado switch
            {
                OrdenStatus.PROCESO => OrdenRefaccionController.I.DeleteRange(Orden.Id),
                OrdenStatus.GARANTIA => OrdenRefaccionGarantiaController.I.DeleteRange(Orden.Id),
                _ => false
            };

            if (!deleted)
                MessageBox.Show("Ocurrio un error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            List<OrdenRefaccion> listR = new List<OrdenRefaccion>();
            List<OrdenRefaccionGarantia> listW = new List<OrdenRefaccionGarantia>();

            //Agrega los registros nuevos
            foreach (DataGridViewRow row in tablaRefacciones.Rows)
            {
                int id = int.Parse(row.Cells[0].Value as string);
                int cantidad = int.Parse(row.Cells[3].Value as string);
                var algo = row.Cells[4].Value.ToString();
                decimal precio = decimal.Parse(algo);

                switch (Estado)
                {
                    case OrdenStatus.PROCESO:
                        listR.Add(new OrdenRefaccion
                        {
                            IdOrden = Orden.Id,
                            IdRefaccion = id,
                            Cantidad = cantidad,
                            PrecioUnitario = precio,
                        });
                        break;

                    case OrdenStatus.GARANTIA:
                        listW.Add(new OrdenRefaccionGarantia
                        {
                            IdOrden = Orden.Id,
                            IdRefaccion = id,
                            Cantidad = cantidad,
                            PrecioUnitario = precio,
                        });
                        break;
                    default:
                        throw new ArgumentException("Error en el estado de la orden");
                }
            }

            var added = Estado switch
            {
                OrdenStatus.PROCESO => OrdenRefaccionController.I.AddRange(listR, Orden),
                OrdenStatus.GARANTIA => OrdenRefaccionGarantiaController.I.AddRange(listW, Orden),
                _ => false
            };

            if (!added)
                MessageBox.Show("Ocurrio un error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            CambiosGuardados = added;
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
                    tablaRefacciones.Rows.Remove(row);
            }
            else
                MessageBox.Show("Seleccione una refaccion en la tabla y vuelva a intentar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (CambiosGuardados)
                CambiosGuardados = false;
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            if ((int)MessageDialogResult.No == MessageDialog.ShowMessageDialog("Confirmacion", "¿Esta seguro que desea completar esta orden?\nYa no podra ser modificada", false)) return;

            //Si la orden esta en proceso se agrega costo de mano de obra, en garantia no tiene costo
            if (Estado == OrdenStatus.PROCESO)
            {
                var aux = LaborCostDialog.ShowLaborCostDialog();

                if (!aux.Result) return; //si no se asigno un valor valido no procede

                OrdenMecanico ordenMecanico = OrdenMecanicoController.I.GetByIdOrden(Orden.Id);
                ordenMecanico.CostoManoObra = aux.Costo;
                ordenMecanico = OrdenMecanicoController.I.Edit(ordenMecanico);

                if (ordenMecanico == null)
                { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }

            Orden.Status = Estado switch
            {
                OrdenStatus.PROCESO => (int)OrdenStatus.POR_ENTREGAR,
                OrdenStatus.GARANTIA => (int)OrdenStatus.GARANTIA_POR_ENTREGAR,
                _ => 0
            };

            Orden = OrdenController.I.Edit(Orden);

            if (Orden == null)
            { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            //Agrega el estado de la orden al historial
            var saved = OrdenHistorialController.I.Add(new OrdenHistorial()
            {
                IdOrden = Orden.Id,
                FechaStatus = DateTime.Now,
                Status = Orden.Status,
            });

            if (saved == null)
                MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((int)MessageDialogResult.No == MessageDialog.ShowMessageDialog("Confirmacion", "¿Esta seguro que desea cancelar esta orden?\nYa no podra ser recuperada", false)) return;

            bool deleted = OrdenRefaccionController.I.DeleteRange(Orden.Id)
                || OrdenRefaccionGarantiaController.I.DeleteRange(Orden.Id);

            deleted &= OrdenMecanicoController.I.DeleteByOrden(Orden.Id);

            if (!deleted)
            { MessageBox.Show("No se puede eliminar la orden, error al eliminar las piezas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            Orden.Status = (int)OrdenStatus.CANCELADA;
            Orden = OrdenController.I.Edit(Orden);
            if (Orden == null)
            { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            //Agrega el estado de la orden al historial
            var saved = OrdenHistorialController.I.Add(new OrdenHistorial()
            {
                IdOrden = Orden.Id,
                FechaStatus = DateTime.Now,
                Status = Orden.Status,
            });

            if (saved == null)
                MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
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
