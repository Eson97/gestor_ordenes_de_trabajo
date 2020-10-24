using DataLayer;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class OrdenItemList : UserControl
    {
        private Orden orden;

        public OrdenItemList()
        {
            InitializeComponent();
        }
        public OrdenItemList(Orden orden)
        {
            InitializeComponent();
            this.orden = orden;
            this.lblOrden.Text = this.orden.Folio.ToString();
            this.lblEquipo.Text = this.orden.Equipo;
            this.lblCliente.Text = this.orden.Cliente.Nombre;
        }

        public void setData(Orden orden)
        {
            this.orden = orden;
            this.lblOrden.Text = this.orden.Folio.ToString();
            this.lblEquipo.Text = this.orden.Equipo;
            this.lblCliente.Text = this.orden.Cliente.Nombre;
        }

        public object getData()
        {
            return this.orden;
        }

    }
}
