﻿using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Enum;
using GestorOrdenesDeTrabajo.UsesCases;
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
    public partial class OrdenesEnProceso : Form
    {
        Orden current;
        public List<OrdenItemList> ListaOrdenes { get; private set; }

        public OrdenesEnProceso()
        {
            InitializeComponent();
            showOrdenes();
        }

        void openSubPanel(Form f)
        {
            //Abre nueva ventana en el panel contenedor
            if (this.ContainerPanel.Controls.Count > 0)
                this.ContainerPanel.Controls.RemoveAt(0);
            Form newPanel = f as Form;
            newPanel.TopLevel = false;
            newPanel.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(newPanel);
            this.ContainerPanel.Tag = newPanel;
            newPanel.Show();
        }

        async void showOrdenes()
        {
            ListaOrdenes = await Task.Run(() => OrdenController.I.GetLista((int)OrdenStatus.PROCESO).Select(el => new OrdenItemList(el)).ToList());

            this.flpOrdenList.Controls.Clear();
            foreach (OrdenItemList item in ListaOrdenes)
            {
                this.flpOrdenList.Controls.Add(item);
                item.btnAction.Click += (s, e) =>
                {
                    current = item.Orden;
                    openSubPanel(new OrdenesEnProceso_AddRem(current));
                };
            }
        }

        private void flpOrdenList_ControlRemoved(object sender, ControlEventArgs e)
        {
            showOrdenes();
        }
    }

}