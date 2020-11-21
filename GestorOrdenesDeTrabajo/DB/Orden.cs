namespace GestorOrdenesDeTrabajo.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orden")]
    public partial class Orden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orden()
        {
            OrdenMecanico = new HashSet<OrdenMecanico>();
            OrdenRefaccion = new HashSet<OrdenRefaccion>();
        }

        public int Id { get; set; }

        public int Folio { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaRecepcion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaEntrega { get; set; }

        [Required]
        [StringLength(50)]
        public string Equipo { get; set; }

        [Required]
        [StringLength(250)]
        public string Observaciones { get; set; }

        [StringLength(11)]
        public string Referencia { get; set; }

        public int? TipoPago { get; set; }

        public int Status { get; set; }

        public int IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenMecanico> OrdenMecanico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenRefaccion> OrdenRefaccion { get; set; }
    }
}
