using System;
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
using GestorOrdenesDeTrabajo.Validation;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnEspera : Form
    {
        private List<OrdenItemList> ListaOrdenes;
        private Orden CurrentOrden;
        private Mecanico CurrentMecanico;
        private readonly OrdenStatus Estado;
        private OrdenValidator OrdenValidator;
        private OrdenHistorialValidator OrdenHistorialValidator;

        public OrdenesEnEspera(OrdenStatus Estado)
        {
            OrdenValidator = new OrdenValidator();
            OrdenHistorialValidator = new OrdenHistorialValidator();
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
                            CurrentOrden = item.Orden;
                            CurrentMecanico = MecanicoDialog.showClientDialog(CurrentOrden);
                            if (CurrentMecanico == null) return;

                            CurrentOrden.Status = AssignNextStatusOrder();

                            //validar Orden antes de modificar
                            var res = OrdenValidator.Validate(CurrentOrden);
                            if (ShowErrorValidation.Valid(res))
                                CurrentOrden = OrdenController.I.Edit(CurrentOrden);

                            if (CurrentOrden == null)
                            { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                            var ordenMecanico = OrdenMecanicoController.I.Add(new OrdenMecanico()
                            {
                                IdOrden = CurrentOrden.Id,
                                IdMecanico = CurrentMecanico.Id
                            });

                            if (ordenMecanico == null)
                            { MessageBox.Show("No se puede asignar el mecanico a la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                            var oh = new OrdenHistorial()
                            {
                                IdOrden = CurrentOrden.Id,
                                FechaStatus = DateTime.Now,
                                Status = AssignNextStatusOrder()
                            };

                            res = OrdenHistorialValidator.Validate(oh);
                            if (ShowErrorValidation.Valid(res))
                            {
                                //Agrega el estado de la orden al historial
                                var saved = OrdenHistorialController.I.Add(oh);
                                if (saved == null)
                                    MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            //Repaint controls with new data
                            showOrdenes();
                        };

                        break;
                    case OrdenStatus.POR_ENTREGAR:
                        this.flpList.Controls.Add(item);
                        item.btnAction.Click += (s, e) =>
                        {
                            CurrentOrden = item.Orden;

                            var aux = EntregarDialog.ShowEntregarOrden(CurrentOrden);
                            if (!aux.Result) return;

                            CurrentOrden.TipoPago = (int)aux.MetodoPago;
                            CurrentOrden.FechaEntrega = aux.FechaEntrega;
                            CurrentOrden.Referencia = aux.Referencia;
                            CurrentOrden.Status = AssignNextStatusOrder();

                            //validar Orden antes de modificar
                            var res = OrdenValidator.Validate(CurrentOrden);
                            if (ShowErrorValidation.Valid(res))
                                CurrentOrden = OrdenController.I.Edit(CurrentOrden);

                            if (CurrentOrden == null)
                            { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                            var ordenHistorial = new OrdenHistorial()
                            {
                                IdOrden = CurrentOrden.Id,
                                FechaStatus = aux.FechaEntrega,
                                Status = AssignNextStatusOrder()
                            };

                            res = OrdenHistorialValidator.Validate(ordenHistorial);
                            if (ShowErrorValidation.Valid(res))
                            {
                                //Agrega el estado de la orden al historial
                                var saved = OrdenHistorialController.I.Add(ordenHistorial);
                                if (saved == null)
                                    MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            //Repaint controls with new data
                            showOrdenes();
                        };
                        break;
                    case OrdenStatus.GARANTIA_POR_ENTREGAR:
                        this.flpList.Controls.Add(item);
                        item.btnAction.Click += (s, e) =>
                        {
                            CurrentOrden = item.Orden;

                            var aux = EntregarDialog.ShowEntregarOrden(CurrentOrden);
                            if (!aux.Result) return;

                            CurrentOrden.FechaEntrega = aux.FechaEntrega;
                            CurrentOrden.Status = AssignNextStatusOrder();

                            //validar Orden antes de modificar
                            var res = OrdenValidator.Validate(CurrentOrden);
                            if (ShowErrorValidation.Valid(res))
                                CurrentOrden = OrdenController.I.Edit(CurrentOrden);

                            if (CurrentOrden == null)
                            { MessageBox.Show("No se puede cambiar el status, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                            var ordenHistorial = new OrdenHistorial()
                            {
                                IdOrden = CurrentOrden.Id,
                                FechaStatus = aux.FechaEntrega,
                                Status = AssignNextStatusOrder()
                            };

                            res = OrdenHistorialValidator.Validate(ordenHistorial);
                            if (ShowErrorValidation.Valid(res))
                            {
                                //Agrega el estado de la orden al historial
                                var saved = OrdenHistorialController.I.Add(ordenHistorial);
                                if (saved == null)
                                    MessageBox.Show("No se puede agregar al historial de ordenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
