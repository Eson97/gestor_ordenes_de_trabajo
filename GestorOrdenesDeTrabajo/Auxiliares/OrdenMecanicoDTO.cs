using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo.Auxiliares
{
    public class OrdenMecanicoDTO
    {
        public int Id { get; set; }

        public int IdOrden { get; set; }

        public int IdMecanico { get; set; }

        public decimal CostoManoObra { get; set; }
    }
}
