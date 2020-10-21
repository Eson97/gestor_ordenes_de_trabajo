using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo.Clases
{
    class RefaccionUso
    {
        private readonly int id;
        string codigo;
        string descripcion;
        double precio_unitario;
        int cantidad;
        double precio_total;

        public RefaccionUso(int id, string codigo, string descripcion, double precio_unitario, int cantidad, double precio_total)
        {
            this.id = id;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio_unitario = precio_unitario;
            this.cantidad = cantidad;
            this.precio_total = precio_total;
        }

        public int Id  => id;
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio_total { get => precio_total; set => precio_total = value; }
    }
}
