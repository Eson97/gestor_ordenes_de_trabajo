namespace GestorOrdenesDeTrabajo.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenMecanico")]
    public partial class OrdenMecanico
    {
        public int Id { get; set; }

        public int IdOrden { get; set; }

        public int IdMecanico { get; set; }

        public decimal CostoManoObra { get; set; }

        public virtual Mecanico Mecanico { get; set; }

        public virtual Orden Orden { get; set; }
    }
}
