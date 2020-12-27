﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.Enums;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using GestorOrdenesDeTrabajo.DB;
using GestorOrdenesDeTrabajo.Ventanas.Ventanas_Emergentes;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnEspera : Form
    {
        private List<OrdenItemList> ListaOrdenes;
        private Orden orden;
        private Mecanico mecanico;
        private readonly OrdenStatus Estado;

        public OrdenesEnEspera(OrdenStatus Estado)
        {
            this.Estado = Estado;
            InitializeComponent();
            showOrdenes();
        }

        async void showOrdenes()
        {
            ListaOrdenes = await Task.Run(() => OrdenController.I.GetLista((int)Estado).Select(el => new OrdenItemList(el)).ToList());

            this.flpList.Controls.Clear();
            foreach (OrdenItemList item in ListaOrdenes)
            {
                switch (Estado)
                {
                    case OrdenStatus.ESPERA:
                        this.flpList.Controls.Add(item);
                        item.btnAction.Click += (s, e) =>
                        {
                            orden = item.Orden;
                            mecanico = MecanicoDialog.showClientDialog(orden);
                            if (mecanico == null) return;

                            orden.Status = AssignNextStatusOrder();
                            orden = OrdenController.I.Edit(orden);
                            if (orden == null)
                            { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                            var ordenMecanico = OrdenMecanicoController.I.Add(new OrdenMecanico()
                            {
                                IdOrden = orden.Id,
                                IdMecanico = mecanico.Id
                            });

                            if (ordenMecanico == null)
                            { MessageBox.Show("No se puede asignar el mecanico a la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                            //Agrega el estado de la orden al historial
                            var saved = OrdenHistorialController.I.Add(new OrdenHistorial()
                            {
                                IdOrden = orden.Id,
                                FechaStatus = DateTime.Now,
                                Status = AssignNextStatusOrder()
                            });

                            if (saved == null)
                                MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //Repaint controls with new data
                            showOrdenes();
                        };

                        break;
                    case OrdenStatus.POR_ENTREGAR:
                        this.flpList.Controls.Add(item);
                        item.btnAction.Click += (s, e) =>
                        {
                            orden = item.Orden;

                            var aux = EntregarDialog.ShowEntregarOrden(orden);
                            if (!aux.Result) return;

                            orden.TipoPago = (int)aux.MetodoPago;
                            orden.FechaEntrega = aux.FechaEntrega;
                            orden.Referencia = aux.Referencia;
                            orden.Status = AssignNextStatusOrder();
                            orden = OrdenController.I.Edit(orden);

                            if (orden == null)
                            { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                            //Agrega el estado de la orden al historial
                            var saved = OrdenHistorialController.I.Add(new OrdenHistorial()
                            {
                                IdOrden = orden.Id,
                                FechaStatus = aux.FechaEntrega,
                                Status = AssignNextStatusOrder()
                            });
                            if (saved == null)
                                MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //Repaint controls with new data
                            showOrdenes();
                        };
                        break;
                    case OrdenStatus.GARANTIA_POR_ENTREGAR:
                        this.flpList.Controls.Add(item);
                        item.btnAction.Click += (s, e) =>
                        {
                            orden = item.Orden;

                            var aux = EntregarDialog.ShowEntregarOrden(orden);
                            if (!aux.Result) return;

                            orden.FechaEntrega = aux.FechaEntrega;
                            orden.Status = AssignNextStatusOrder();
                            orden = OrdenController.I.Edit(orden);

                            if (orden == null)
                            { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                            //Agrega el estado de la orden al historial
                            var saved = OrdenHistorialController.I.Add(new OrdenHistorial()
                            {
                                IdOrden = orden.Id,
                                FechaStatus = aux.FechaEntrega,
                                Status = AssignNextStatusOrder()
                            });
                            if (saved == null)
                                MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //Repaint controls with new data
                            showOrdenes();
                        };
                        break;
                    default:
                        throw new ArgumentException("No se soporta el status", nameof(OrdenStatus));
                }
            }
        }

        //Cambia el status de la orden a la siguiente etapa
        private int AssignNextStatusOrder()
        {
            var a = Estado switch
            {
                OrdenStatus.ESPERA => (int)OrdenStatus.PROCESO,
                OrdenStatus.POR_ENTREGAR => (int)OrdenStatus.ENTREGADA,
                OrdenStatus.GARANTIA_POR_ENTREGAR => (int)OrdenStatus.GARANTIA_ENTREGADA,
                _ => throw new ArgumentException("No se soporta el status", nameof(OrdenStatus))
            };

            return a;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.TextLength == 0)
            {
                foreach (OrdenItemList item in flpList.Controls)
                    item.Visible = true;
                return;
            }

            string folio = txtFiltro.Text;

            foreach (OrdenItemList item in flpList.Controls)
            {
                if (!item.Folio.Contains(folio)) item.Visible = false;
                else item.Visible = true;
            }
        }
    }
}
