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
        private List<PiezaItemList> refacciones;
        public SrchPiezasUsadas(int idOrden)
        {
            InitializeComponent();
            showRefacciones();
            IdOrden = idOrden;
        }
        async void showRefacciones()
        {
            this.flpListPanel.Controls.Clear();

            refacciones = await Task.Run(() => RefaccionController.I.GetListaByOrden(IdOrden).Select(el => new PiezaItemList(el)).ToList());
            foreach (PiezaItemList item in refacciones)
            {
                this.flpListPanel.Controls.Add(item);
            }
        }
    }
}
