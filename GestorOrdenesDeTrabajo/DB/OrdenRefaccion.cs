namespace GestorOrdenesDeTrabajo.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenRefaccion")]
    public partial class OrdenRefaccion
    {
        public int Id { get; set; }

        public int IdOrden { get; set; }

        public int IdRefaccion { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int Cantidad { get; set; }

        public virtual Orden Orden { get; set; }

        public virtual Refaccion Refaccion { get; set; }
    }
}
