using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BussinessLayer.Enum;
using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.Ventanas.Message;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnEspera : Form
    {
        private readonly List<OrdenItemList> ListaOrdenes;
        private Orden orden;
        private Mecanico mecanico;

        public OrdenesEnEspera()
        {
            InitializeComponent();
            ListaOrdenes = OrdenController.I.GetLista((int)OrdenStatus.ESPERA).Select(el => new OrdenItemList(el)).ToList();
            showOrdenes();
        }

        void showOrdenes()
        {
            foreach (OrdenItemList item in ListaOrdenes)
            {
                this.flpList.Controls.Add(item);
                item.btnAction.Click += (s, e) =>
                {
                    orden = item.Orden;
                    Console.WriteLine(orden.Cliente.Nombre);
                };
            }
        }
        void fillData(Mecanico m)
        {
            if (m != null)
            {
                //txtCliente.Text = c.Nombre;
                //txtDireccion.Text = c.Direccion;
                //txtTelefono.Text = c.Telefono;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mecanico = MecanicoDialog.showClientDialog();
            fillData(mecanico);
        }
    }
}
