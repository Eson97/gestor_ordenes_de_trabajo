using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Clases
{
    class Orden
    {
        private readonly int id;
        private int folio;
        private string cliente;
        private string direccion;
        private string telefono;
        private string equipo;
        private string mecanico;
        private string observaciones;
        private DateTime recepcion;
        private DateTime entrega;
        private int estado;
        private int metodo_pago;
        private string referencia;

        public Orden(int id, int folio, string cliente, string equipo)
        {
            this.id = id;
            this.folio = folio;
            this.cliente = cliente;
            this.equipo = equipo;
        }

        public Orden(int id, int folio, string cliente, int estado)
        {
            this.id = id;
            this.folio = folio;
            this.cliente = cliente;
            this.estado = estado;
        }

        public Orden(int folio, string cliente, string direccion, string telefono, string maquina,string observaciones,DateTime recepcion)
        {
            this.folio = folio;
            this.cliente = cliente;
            this.direccion = direccion;
            this.telefono = telefono;
            this.equipo = maquina;
            this.observaciones = observaciones;
            this.recepcion = recepcion;
            this.estado = (int)Clases.Estado.EN_ESPERA;
        }

        public Orden(int id, int folio, string cliente, string direccion, string telefono, string maquina, string mecanico, string observaciones, DateTime recepcion, DateTime entrega, int estado, int metodo_pago, string referencia)
        {
            this.id = id;
            this.Folio = folio;
            this.Cliente = cliente;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Equipo = maquina;
            this.Mecanico = mecanico;
            this.Observaciones = observaciones;
            this.Recepcion = recepcion;
            this.Entrega = entrega;
            this.Estado = estado;
            this.Metodo_pago = metodo_pago;
            this.Referencia = referencia;
        }


        public int ID => id;

        public int Folio { get => folio; set => folio = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Equipo { get => equipo; set => equipo = value; }
        public string Mecanico { get => mecanico; set => mecanico = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public DateTime Recepcion { get => recepcion; set => recepcion = value; }
        public DateTime Entrega { get => entrega; set => entrega = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Metodo_pago { get => metodo_pago; set => metodo_pago = value; }
        public string Referencia { get => referencia; set => referencia = value; }



        public override string ToString()
        {
            return $"ID: {ID}\nFolio: {Folio}\nCliente: {cliente}\nDireccion: {Direccion}\nTelefono: {Telefono}\nEquipo: {Equipo}" ;
        }

        public object[] ToArraySimpleInfo()
        {
            return new object[] { ID, Folio, Cliente, EstadoToString() };
        }

        private string EstadoToString()
        {
            switch (estado)
            {
                case (int)Clases.Estado.EN_ESPERA:
                    return "EN ESPERA";
                case (int)Clases.Estado.EN_PROCESO:
                    return "EN PROCESO";
                case (int)Clases.Estado.POR_ENTREGAR:
                    return "POR ENTREGAR";
                case (int)Clases.Estado.ENTREGADA:
                    return "ENTREGADA";
                case (int)Clases.Estado.GARANTIA:
                    return "GARANTIA";
                case (int)Clases.Estado.CANCELADA:
                    return "CANCELADA";
                default: 
                    return null;
            }
        }
    }
}
