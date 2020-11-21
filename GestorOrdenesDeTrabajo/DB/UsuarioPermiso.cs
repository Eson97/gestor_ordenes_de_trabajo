namespace GestorOrdenesDeTrabajo.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsuarioPermiso")]
    public partial class UsuarioPermiso
    {
        [Key]
        public int IdUsuarioPermiso { get; set; }

        public int IdUsuario { get; set; }

        public int IdPermiso { get; set; }

        public virtual Permiso Permiso { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
