using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesGarantia : Form
    {
        public List<OrdenItemList> ListaOrdenes { get; private set; }
        public OrdenesGarantia()
        {
            InitializeComponent();
            showOrdenes();
            fbtnAdd.Location = new System.Drawing.Point(fbtnAdd.Parent.Width - 10, fbtnAdd.Parent.Height - 10);
        }

        async void showOrdenes()
        {
            ListaOrdenes = await Task.Run(() => OrdenController.I.GetLista((int)OrdenStatus.GARANTIA).Select(el => new OrdenItemList(el)).ToList());

            if (this.flpList.Controls.Count == ListaOrdenes.Count) return;

            this.flpList.Controls.Clear();
            foreach (OrdenItemList item in ListaOrdenes)
            {
                this.flpList.Controls.Add(item);
                item.btnAction.Click += (s, e) =>
                {
                    //TODO addnew Date to orden
                };
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            //TODO display add garanty window
        }

        private void OrdenesGarantia_Resize(object sender, System.EventArgs e)
        {
            fbtnAdd.Location = new System.Drawing.Point(fbtnAdd.Parent.Width - (fbtnAdd.Width + 10), fbtnAdd.Parent.Height - (fbtnAdd.Height + 10));
        }

        private void txtFiltro_TextChanged(object sender, System.EventArgs e)
        {
            if (txtFiltro.TextLength == 0)
            {
                foreach (OrdenItemList item in flpList.Controls)
                    item.Visible = true;
                return;
            }

            string folio = txtFiltro.Text;

            foreach (OrdenItemList item in flpList.Controls)
            {

                if (!item.Folio.Contains(folio)) item.Visible = false;
                else item.Visible = true;
            }
        }
    }
}
