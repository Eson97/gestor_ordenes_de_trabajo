using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BussinessLayer.Enum;
using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.CustomComponents;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnEspera : Form
    {
        List<OrdenItemList> ListaOrdenes;
        Orden orden;

        public OrdenesEnEspera()
        {
            InitializeComponent();
            ListaOrdenes = OrdenController.I.GetLista((int)OrdenStatus.ESPERA).Select(el => new OrdenItemList(el)).ToList();

            showOrdenes();
        }

        void openSubPanel()
        {

        }

        void showOrdenes()
        {
            foreach (OrdenItemList item in ListaOrdenes)
            {
                this.flpList.Controls.Add(item);
                item.btnAction.Click += (s, e) =>
                {
                    orden = item.getData() as Orden;
                    Console.WriteLine(orden.Cliente);
                };
            }
        }

    }
}
