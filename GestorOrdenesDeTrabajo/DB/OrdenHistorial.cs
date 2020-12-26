
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorOrdenesDeTrabajo.DB
{
    [Table("OrdenHistorial")]
    public class OrdenHistorial
    {
        public int Id { get; set; }

        public int IdOrden { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaStatus { get; set; }

        public int Status { get; set; }

        public virtual Orden Orden { get; set; }
    }
}
