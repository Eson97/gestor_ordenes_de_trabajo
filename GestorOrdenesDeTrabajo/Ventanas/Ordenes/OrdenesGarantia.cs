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
    }
}
