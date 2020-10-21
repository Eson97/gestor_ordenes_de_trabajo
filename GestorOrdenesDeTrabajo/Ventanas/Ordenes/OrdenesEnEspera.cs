using GestorOrdenesDeTrabajo.Clases;
using GestorOrdenesDeTrabajo.CustomComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnEspera : Form
    {
        List<OrdenItemList> ListaOrdenes;
        Orden orden;

        public OrdenesEnEspera()
        {
            InitializeComponent();
            ListaOrdenes = new List<OrdenItemList>();
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(1, 123456, "Radamez", "Equipo1")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(2, 123123, "Gregorio", "Equipo2")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(3, 456456, "Geronimo", "Equipo3")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(4, 789789, "Nabucodonosor", "Equipo4")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(4, 789789, "Ramiro", "Equipo5")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(4, 789789, "Nayelli", "Equipo6")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(4, 789789, "Jennice", "Equipo7")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(4, 789789, "Montse", "Equipo8")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(4, 789789, "Jesus", "Equipo9")));
            ListaOrdenes.Add(new OrdenItemList(new Clases.Orden(4, 789789, "Beto", "Equipo10")));
            showOrdenes();
        }

        void openSubPanel()
        {

        }

        void showOrdenes()
        {
            foreach(OrdenItemList item in ListaOrdenes)
            {
                this.flpList.Controls.Add(item);
                item.btnAction.Click += (s, e) => {
                    orden = item.getData() as Orden;
                    Console.WriteLine(orden.Cliente);
                };
            }
        }

    }
}
