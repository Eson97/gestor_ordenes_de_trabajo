using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.CustomComponents;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace GestorOrdenesDeTrabajo.Ventanas.Buscar
{

    //@todo Fix SrchPiezasUsadas
    //@body Al consultar mas de una vez deja de mostrar las refacciones

    public partial class SrchPiezasUsadas : Form
    {
        private readonly int IdOrden;
        private decimal Total = 0.0M;
        private List<PiezaItemList> refacciones;
        public SrchPiezasUsadas(int idOrden)
        {
            InitializeComponent();
            IdOrden = idOrden;
            lblTittle.Text = idOrden.ToString();
        }
        async void showRefacciones()
        {
            this.flpListPanel.Controls.Clear();
            refacciones = await Task.Run(() => OrdenRefaccionController.I.GetListaByOrden(IdOrden).Select(el => new PiezaItemList(el)).ToList());

            refacciones.ForEach(item =>
            {
               Total += item.Refaccion.Total;
               this.flpListPanel.Controls.Add(item);
            });

            this.ipTotal.Info = Total;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void SrchPiezasUsadas_Load(object sender, EventArgs e)
        {
            showRefacciones();
        }
    }
}
