using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnProceso : Form
    {
        Orden current;
        OrdenStatus Estado;
        public List<OrdenItemList> ListaOrdenes { get; private set; }

        public OrdenesEnProceso(OrdenStatus Estado)
        {
            InitializeComponent();
            loadOrdenes();
            this.Estado = Estado;

        }

        void openSubPanel(Form f)
        {
            //Abre nueva ventana en el panel contenedor
            if (this.ContainerPanel.Controls.Count > 0)
                this.ContainerPanel.Controls.RemoveAt(0);
            Form newPanel = f as Form;
            newPanel.TopLevel = false;
            newPanel.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(newPanel);
            this.ContainerPanel.Tag = newPanel;
            newPanel.Show();
        }

        async void loadOrdenes()
        {
            //ListaOrdenes = await Task.Run(() => OrdenController.I.GetLista((int)OrdenStatus.PROCESO).Select(el => new OrdenItemList(el)).ToList());
            ListaOrdenes = await Task.Run(() => OrdenController.I.GetLista((int)Estado).Select(el => new OrdenItemList(el)).ToList());

            if (this.flpOrdenList.Controls.Count == ListaOrdenes.Count) return;

            this.flpOrdenList.Controls.Clear();
            foreach (OrdenItemList item in ListaOrdenes)
            {
                this.flpOrdenList.Controls.Add(item);
                item.btnAction.Click += (s, e) =>
                {
                    current = item.Orden;
                    openSubPanel(new OrdenesEnProceso_AddRem(current,Estado));
                };
            }
        }

        private void ContainerPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            loadOrdenes();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.TextLength == 0)
            {
                foreach (OrdenItemList item in flpOrdenList.Controls)
                    item.Visible = true;
                return;
            }

            string folio = txtFiltro.Text;

            foreach (OrdenItemList item in flpOrdenList.Controls)
            {

                if (!item.Folio.Contains(folio)) item.Visible = false;
                else item.Visible = true;
            }
        }

        private void OrdenesEnProceso_Resize(object sender, EventArgs e)
        {
            if(Estado == OrdenStatus.GARANTIA)
                fbtnAdd.Location = new System.Drawing.Point(fbtnAdd.Parent.Width - (fbtnAdd.Width + 10), fbtnAdd.Parent.Height - (fbtnAdd.Height + 10));
        }

        private void OrdenesEnProceso_Load(object sender, EventArgs e)
        {
            if (Estado == OrdenStatus.GARANTIA)
            {
                fbtnAdd.Location = new System.Drawing.Point(fbtnAdd.Parent.Width - 10, fbtnAdd.Parent.Height - 10);
                fbtnAdd.Show(); ;
            }

        }

        private void fbtnAdd_Click(object sender, EventArgs e)
        {
            //TODO Agregar orden a garantia (Solo entregadas)
        }
    }

}