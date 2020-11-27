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
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnProceso_AddRem : Form
    {
        Orden orden;
        DataTable datatable;
        List<RefaccionDTO> Refacciones;
        bool CambiosGuardados = true;

        public OrdenesEnProceso_AddRem(Orden o)
        {
            InitializeComponent();
            this.orden = o;
            Refacciones = new List<RefaccionDTO>();
            //this.lblCliente.Text = orden.Cliente.Nombre;
            //this.lblEquipo.Text = orden.Equipo;
            //this.lblFolio.Text = orden.Folio.ToString();


            datatable = new DataTable();
            datatable.Columns.Add("ID");
            datatable.Columns.Add("Codigo");
            datatable.Columns.Add("Descripcion");
            datatable.Columns.Add("Cant");
            datatable.Columns.Add("P/U");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = false;
            datatable.Columns[2].ReadOnly = false;
            datatable.Columns[3].ReadOnly = false;
            datatable.Columns[4].ReadOnly = false;
            datatable.Columns[4].DataType = typeof(decimal);

            getPiecesInWorkOrder();
        }

        void getPiecesInWorkOrder()
        {
            while (tablaRefacciones.RowCount != 0)
                tablaRefacciones.Rows.RemoveAt(0);

            Refacciones = OrdenRefaccionController.I.GetListaByOrden(1);
            foreach (RefaccionDTO item in Refacciones)
                datatable.Rows.Add(new object[] { item.Id, item.Codigo, item.Descripcion, item.Cantidad, item.PrecioUnitrio });

            tablaRefacciones.DataSource = datatable;
            tablaRefacciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaRefacciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaRefacciones.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaRefacciones.Columns[0].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[1].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[2].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaRefacciones.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        void UpdatePiecesInWorkOrder()
        {
            //TODO Actualizar piezas en la orden de trabajo
            foreach (DataGridViewRow row in tablaRefacciones.Rows)
            {
                int id = int.Parse(row.Cells[0].Value as string);
                string code = row.Cells[1].Value as string;
                string pieza = row.Cells[2].Value as string;
                double precio = double.Parse(row.Cells[3].Value as string);

                OrdenRefaccionController.I.Add(new OrdenRefaccion
                {

                });
                //update in db
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
            if (!CambiosGuardados)// si no se han guardado cambios: se cambia estado y se guardan
            {
                CambiosGuardados = !CambiosGuardados;
                UpdatePiecesInWorkOrder();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Refacciones.AddRange(SelectRefaccionDialog.showSRDialog(orden));

            //agrupa piezas repetidas y suma la cantidad de piezas usadas >>En caso de haber diferencia en P/u tomar el valor mas alto?<<

            //var result = Refacciones.GroupBy(el => el.Id)
            //    .Select(ele => new
            //    {
            //        Id = ele.Key,
            //        Cantidad = ele.Sum(i => i.Cantidad),
            //        PrecioUnitrio = ele.Max(i => i.PrecioUnitrio)
            //    }).ToList();

            if (CambiosGuardados)
                CambiosGuardados = false;
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            //TODO agregar codigo para quitar una pieza (o que se quiten directamente desde el control?)

            if (CambiosGuardados)
                CambiosGuardados = false;
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            //TODO pasar la orden de trabajo al siguiente estado (Por entregar)
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //TODO pasar la orden al estado de Cancelado
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
