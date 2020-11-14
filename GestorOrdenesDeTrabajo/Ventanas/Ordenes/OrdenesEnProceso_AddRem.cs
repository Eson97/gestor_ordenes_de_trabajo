using BussinessLayer.Enum;
using DataLayer;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnProceso_AddRem : Form
    {
        Orden orden;
        bool CambiosGuardados;
        public OrdenesEnProceso_AddRem(Orden o)
        {
            InitializeComponent();
            this.orden = o;
            //this.lblCliente.Text = orden.Cliente.Nombre;
            //this.lblEquipo.Text = orden.Equipo;
            //this.lblFolio.Text = orden.Folio.ToString();

            getPiecesInWorkOrder();
        }

        void getPiecesInWorkOrder()
        {
            //TODO obtener piezas ya cargadas en la orden de trabajo y cargarlas en el flowlayoutpanel

        }

        void UpdatePiecesInWorkOrder()
        {
            //TODO Actualizar piezas en la orden de trabajp
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            if(!CambiosGuardados)// si no se han guardado cambios: se pide confirmacion antes de cerrar
            {
                if (CambiosGuardados && MessageDialog.ShowMessageDialog("Confirmacion", "¿Desea guardar cambios antes de cerrar?", false) == (int)MessageDialogResult.No) 
                    this.Dispose();

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
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            //TODO agregar codigo para quitar una pieza (o que se quiten directamente desde el control?)
        }

        private void flpItemList_ControlAdded(object sender, ControlEventArgs e)
        {
            if(CambiosGuardados)
                CambiosGuardados = false;
        }

        private void flpItemList_ControlRemoved(object sender, ControlEventArgs e)
        {
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
    }
}
