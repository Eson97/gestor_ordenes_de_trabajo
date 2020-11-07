﻿using System;
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
        private List<OrdenItemList> ListaOrdenes;
        private Orden orden;
        private Mecanico mecanico;

        public OrdenesEnEspera()
        {
            InitializeComponent();
            showOrdenes();
        }

        void showOrdenes()
        {           
            this.flpList.Controls.Clear();
            ListaOrdenes = OrdenController.I.GetLista((int)OrdenStatus.ESPERA).Select(el => new OrdenItemList(el)).ToList();

            foreach (OrdenItemList item in ListaOrdenes)
            {
                this.flpList.Controls.Add(item);
                item.btnAction.Click += (s, e) =>
                {
                    orden = item.Orden;
                    mecanico = MecanicoDialog.showClientDialog();
                    if (mecanico == null) return;

                    orden.Status = (int)OrdenStatus.PROCESO;
                    orden = OrdenController.I.Edit(orden);

                    var ordenMecanico = OrdenMecanicoController.I.Add(new OrdenMecanico()
                    {
                        IdOrden = orden.Id,
                        IdMecanico = mecanico.Id
                    });

                    if (ordenMecanico == null)
                        MessageBox.Show("No se puede asignar el mecanico a la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Repaint controls with new data
                    showOrdenes();
                };
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}
