
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorOrdenesDeTrabajo.DB
{
    [Table("OrdenRefaccionGarantia")]
    public partial class OrdenRefaccionGarantia
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
