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
using DataLayer;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class PiezaItemList : UserControl
    {
        //TODO hacer funcionar este control con las refacciones en ordenes

        Refaccion refaccion;

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

        }

        public object getData()
        {
            return refaccion;
        }

    }
}
