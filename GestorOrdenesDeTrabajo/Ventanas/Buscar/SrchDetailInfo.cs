﻿using BussinessLayer.Enum;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Ventanas.Buscar
{
    public partial class SrchDetailInfo : Form
    {
        private readonly Orden orden;
        private readonly string mecanicos;
        private readonly Cliente c;

        public SrchDetailInfo(Orden orden, List<Mecanico> mecanicosByOrden)
        {
            InitializeComponent();
            this.orden = orden;
            this.c = orden.Cliente;

            foreach (var item in mecanicosByOrden)
                this.mecanicos += item.ToString() + ", ";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SrchDetailInfo_Load(object sender, EventArgs e)
        {
            lblID.Text = orden.Id.ToString();
            lblFolio.Text = orden.Folio.ToString();
            lblEstado.Text = OrdenStatusManager.ToString(orden.Status);
            lblObservaciones.Text = orden.Observaciones;
            lblTelefono.Text = c.Telefono;
            lblCliente.Text = c.Nombre;
            lblDireccion.Text = c.Direccion;
            lblRecepcion.Text = orden.FechaRecepcion.ToString("dd/MM/yyyy");
            lblEntrega.Text = orden.FechaEntrega.GetValueOrDefault(DateTime.MinValue).ToString("dd/MM/yyyy");
            lblMecanico.Text = mecanicos;

            //TODO modify DB?
            //lblMet_Pago.Text
            //lblReferencia.Text

        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            //TODO ABRIR NUEVA VENTANA DONDE SE OBSERVARAN LAS PIEZAS ADJUNTAS A LA ORDEN DE TRABAJO
        }
    }
}
