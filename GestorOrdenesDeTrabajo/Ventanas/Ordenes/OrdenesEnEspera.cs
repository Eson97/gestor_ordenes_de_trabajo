using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorOrdenesDeTrabajo.Enum;
using GestorOrdenesDeTrabajo.UsesCases;
using GestorOrdenesDeTrabajo.CustomComponents;
using GestorOrdenesDeTrabajo.Ventanas.Message;
using GestorOrdenesDeTrabajo.DB;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class OrdenesEnEspera : Form
    {
        private List<OrdenItemList> ListaOrdenes;
        private Orden orden;
        private Mecanico mecanico;
        private readonly int status;

        public OrdenesEnEspera(int Status)
        {
            status = Status;
            InitializeComponent();
            showOrdenes();
        }

        async void showOrdenes()
        {
            ListaOrdenes = await Task.Run(() => OrdenController.I.GetLista(status).Select(el => new OrdenItemList(el)).ToList());

            this.flpList.Controls.Clear();
            foreach (OrdenItemList item in ListaOrdenes)
            {
                switch (status)
                {
                    case (int)OrdenStatus.ESPERA:
                        this.flpList.Controls.Add(item);
                        item.btnAction.Click += (s, e) =>
                        {
                            orden = item.Orden;
                            mecanico = MecanicoDialog.showClientDialog(orden);
                            if (mecanico == null) return;

                            orden.Status = AssignNextStatusOrder();
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

                        break;
                    case (int)OrdenStatus.POR_ENTREGAR:
                        this.flpList.Controls.Add(item);
                        item.btnAction.Click += (s, e) =>
                        {
                            orden = item.Orden;

                            //TODO add forma de pago 
                            orden.FechaEntrega = DateTime.Now;
                            orden.Status = AssignNextStatusOrder();
                            orden = OrdenController.I.Edit(orden);

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
            switch (status)
            {
                case (int)OrdenStatus.ESPERA:
                    return (int)OrdenStatus.PROCESO;

                case (int)OrdenStatus.POR_ENTREGAR:
                    return (int)OrdenStatus.ENTREGADA;

                default:
                    throw new ArgumentException("No se soporta el status", nameof(OrdenStatus));
            };

            //var a = status switch
            //{
            //    (int)OrdenStatus.ESPERA => (int)OrdenStatus.PROCESO,
            //    (int)OrdenStatus.POR_ENTREGAR => (int)OrdenStatus.ENTREGADA,
            //    _ => -1
            //};
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}
