using BussinessLayer.UsesCases;
using GestorOrdenesDeTrabajo.CustomComponents;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Buscar
{
    public partial class SrchPiezasUsadas : Form
    {
        private readonly int IdOrden;
        private decimal Total = 0.0M;
        private List<PiezaItemList> refacciones;
        public SrchPiezasUsadas(int idOrden)
        {
            InitializeComponent();
            showRefacciones();
            IdOrden = idOrden;
            lblTittle.Text = idOrden.ToString();
        }
        async void showRefacciones()
        {
            this.flpListPanel.Controls.Clear();
            refacciones = await Task.Run(() => OrdenRefaccionController.I.GetListaByOrden(IdOrden).Select(el => new PiezaItemList(el)).ToList());
            foreach (PiezaItemList item in refacciones)
            {
                Total += item.Refaccion.Total;
                this.flpListPanel.Controls.Add(item);
            }
            //TODO agregar total a infopanel1
            this.infoPanel1.updateData("Total", Total);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
