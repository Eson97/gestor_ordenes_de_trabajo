using System.Windows.Forms;
using DataLayer;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class PiezaItemList : UserControl
    {
        public PiezaItemList()
        {
            InitializeComponent();
            Refaccion = new Refaccion();
        }

        public PiezaItemList(Refaccion refaccion)
        {
            InitializeComponent();
            this.Refaccion = refaccion;
            //TODO Cambiar refaccion por RefaccionDTO con cantidad, descripcion y total calculado
            lblPieza.Text = Refaccion.Descripcion;
        }


        public Refaccion Refaccion { get; internal set; }

    }
}
