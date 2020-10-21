using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.Clases;
using System.Globalization;
using System.Diagnostics.PerformanceData;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class PiezaItemList : UserControl
    {
        private RefaccionUso refaccion;

        public PiezaItemList()
        {
            InitializeComponent();
        }

        public PiezaItemList(object refaccion_uso)
        {
            InitializeComponent();
            setData(refaccion);
        }

        public void setData(object refaccion)
        {
            this.refaccion = refaccion as RefaccionUso;
            lblPieza.Text = this.refaccion.Descripcion;
            lblCantidad.Text = this.refaccion.Cantidad.ToString();
            lblTotal.Text = string.Format(new CultureInfo("es-MX"), "{0:C2}", this.refaccion.Precio_total);
        }

        public object getData()
        {
            return refaccion;
        }

    }
}
