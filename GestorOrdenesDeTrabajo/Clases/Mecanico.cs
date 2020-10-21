using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo.Clases
{
    class Mecanico
    {
        private readonly int id;
        private string nombre;

        public Mecanico(int id, string nombre)
        {
            this.id = id;
            this.Nombre = nombre;
        }

        public int ID => id;

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
