using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enum;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnProceso_AddRem : Form
    {
        Orden orden;
        DataTable datatable;
        bool CambiosGuardados = true;

        public OrdenesEnProceso_AddRem(Orden o)
        {
            InitializeComponent();
            this.orden = o;
            //this.lblCliente.Text = orden.Cliente.Nombre;
            //this.lblEquipo.Text = orden.Equipo;
            //this.lblFolio.Text = orden.Folio.ToString();


            datatable = new DataTable();
            datatable.Columns.Add("Codigo");
            datatable.Columns.Add("Cant");
            datatable.Columns[0].ReadOnly = true;
            datatable.Columns[1].ReadOnly = false;

            getPiecesInWorkOrder();
        }

        void getPiecesInWorkOrder()
        {
            while (tablaRefacciones.RowCount != 0)
                tablaRefacciones.Rows.RemoveAt(0);

            //Obtener piezas ya cargadas

            tablaRefacciones.DataSource = datatable;
            tablaRefacciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tablaRefacciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablaRefacciones.Columns[0].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[1].Resizable = DataGridViewTriState.True;
            tablaRefacciones.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        void UpdatePiecesInWorkOrder()
        {
            //TODO Actualizar piezas en la orden de trabajp
            foreach (DataGridViewRow row in tablaRefacciones.Rows)
            {
                //update in db
            }

            CambiosGuardados = true;
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            if(!CambiosGuardados)// si no se han guardado cambios: se pide confirmacion antes de cerrar
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
            //TODO agregar codigo para agregar una nueva pieza

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

            if (CambiosGuardados)
                CambiosGuardados = false;
        }

        private void tablaRefacciones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (CambiosGuardados)
                CambiosGuardados = false;
        }
    }
}
