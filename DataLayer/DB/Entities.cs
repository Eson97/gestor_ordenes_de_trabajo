namespace DataLayer.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Mecanico> Mecanico { get; set; }
        public virtual DbSet<Orden> Orden { get; set; }
        public virtual DbSet<OrdenMecanico> OrdenMecanico { get; set; }
        public virtual DbSet<OrdenRefaccion> OrdenRefaccion { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Refaccion> Refaccion { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioPermiso> UsuarioPermiso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Orden)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mecanico>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Mecanico>()
                .HasMany(e => e.OrdenMecanico)
                .WithRequired(e => e.Mecanico)
                .HasForeignKey(e => e.IdMecanico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden>()
                .Property(e => e.Equipo)
                .IsUnicode(false);

            modelBuilder.Entity<Orden>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Orden>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Orden>()
                .HasMany(e => e.OrdenMecanico)
                .WithRequired(e => e.Orden)
                .HasForeignKey(e => e.IdOrden)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden>()
                .HasMany(e => e.OrdenRefaccion)
                .WithRequired(e => e.Orden)
                .HasForeignKey(e => e.IdOrden)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdenMecanico>()
                .Property(e => e.CostoManoObra)
                .HasPrecision(4, 2);

            modelBuilder.Entity<OrdenRefaccion>()
                .Property(e => e.PrecioUnitario)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Permiso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Permiso>()
                .HasMany(e => e.UsuarioPermiso)
                .WithRequired(e => e.Permiso)
                .HasForeignKey(e => e.IdPermiso);

            modelBuilder.Entity<Refaccion>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Refaccion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Refaccion>()
                .Property(e => e.PrecioMinimo)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Refaccion>()
                .HasMany(e => e.OrdenRefaccion)
                .WithRequired(e => e.Refaccion)
                .HasForeignKey(e => e.IdRefaccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.UsuarioPermiso)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdUsuario);
        }
    }
}
