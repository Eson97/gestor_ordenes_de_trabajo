﻿using System;
using System.Linq;
using System.Windows.Forms;
using BussinessLayer.Enum;
using BussinessLayer.UsesCases;
using DataLayer;
using GestorOrdenesDeTrabajo.Utilerias.Controles;
using GestorOrdenesDeTrabajo.Utilerias.Eventos;
using GestorOrdenesDeTrabajo.Ventanas.Message;

namespace GestorOrdenesDeTrabajo.Ventanas.Ordenes
{
    public partial class NuevaOrden : Form
    {
        /**
         * TODO cambiar funcionamiento para agregar cliente
         * Suplir el ingreso de datos por el ususario con el uso de <SrchClienteDialog> 
         */

        Cliente c;

        public NuevaOrden()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            Helper.VaciarTexto(txtEquipo, txtFolio, txtObservaciones, txtCliente, txtDireccion, txtTelefono);
            cdtpFechaRecepcion.Value = DateTime.Now;
        }

        void fillData(Cliente c)
        {
            if (c != null)
            {
                txtCliente.Text = c.Nombre;
                txtDireccion.Text = c.Direccion;
                txtTelefono.Text = c.Telefono;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiar todos los campos
            Limpiar();
        }

        private void changeFocus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Helper.Llenos(txtEquipo, txtObservaciones, txtFolio);
            if (c == null && isEmpty)
                return;

            int folio = int.Parse(txtFolio.Text);
            string equipo = txtEquipo.Text;
            string observaciones = txtObservaciones.Text;
            DateTime recepcion = cdtpFechaRecepcion.Value;

            //TODO agregar validaciones


            //Se crea la entidad cliente automaticamente TODO revisar si el cliente existe y solo agregar ID

            var orden = OrdenController.I.Add(new Orden()
            {
                Folio = folio,
                Equipo = equipo,
                FechaRecepcion = recepcion,
                Observaciones = observaciones,
                Status = (int)OrdenStatus.ESPERA,
                Cliente = c,
            });


            Console.WriteLine(orden.ToString());
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                c = SrchClienteDialog.showClientDialog();
                fillData(c);
            }
        }

        private void btnSrchCliente_Click(object sender, EventArgs e)
        {
            c = SrchClienteDialog.showClientDialog();
            fillData(c);
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.SoloNumeros(e);
        }

        private void txtEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoSpaceComaPunto(e);
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtro.AlfanumericoSpaceComaPunto(e);
        }
    }
}
