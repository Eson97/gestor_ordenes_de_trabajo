﻿using GestorOrdenesDeTrabajo.DB;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.CustomComponents
{
    public partial class OrdenItemList : UserControl
    {
        private Orden orden;

        public string Folio { get => orden.Folio.ToString(); }

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

        //TODO si existe el constructor para que necesitariamos set?
        public Orden Orden
        {
            get { return orden; }
            set
            {
                this.orden = value as Orden;
                this.lblOrden.Text = this.orden.Folio.ToString();
                this.lblEquipo.Text = this.orden.Equipo;
                this.lblCliente.Text = this.orden.Cliente.Nombre;
            }
        }

        private void btnAction_Click(object sender, System.EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
