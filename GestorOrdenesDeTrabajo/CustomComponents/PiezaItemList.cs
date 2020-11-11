using System.Windows.Forms;
using DataLayer.Auxiliares;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class PiezaItemList : UserControl
    {
        public PiezaItemList()
        {
            InitializeComponent();
        }

        public PiezaItemList(RefaccionDTO refaccion)
        {
            InitializeComponent();
            this.Refaccion = refaccion;
            lblPieza.Text = Refaccion.Descripcion;
            lblCantidad.Text = Refaccion.Cantidad.ToString();
            lblTotal.Text = "$" + Refaccion.Total;
        }


        public RefaccionDTO Refaccion { get; internal set; }

    }
}
