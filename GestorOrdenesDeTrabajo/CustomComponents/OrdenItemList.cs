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

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class OrdenItemList : UserControl
    {
        private Clases.Orden orden;

        public OrdenItemList()
        {
            InitializeComponent();
        }
        public OrdenItemList(object orden)
        {
            InitializeComponent();
            this.orden = orden as Clases.Orden;
            this.lblOrden.Text = this.orden.Folio.ToString();
            this.lblEquipo.Text = this.orden.Equipo;
            this.lblCliente.Text = this.orden.Cliente;
        }

        public void setData(object orden)
        {
            this.orden = orden as Clases.Orden;
            this.lblOrden.Text = this.orden.Folio.ToString();
            this.lblEquipo.Text = this.orden.Equipo;
            this.lblCliente.Text = this.orden.Cliente;
        }

        public object getData()
        {
            return this.orden;
        }

    }
}
