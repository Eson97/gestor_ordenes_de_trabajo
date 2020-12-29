namespace GestorOrdenesDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 70, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orden",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Folio = c.Int(nullable: false),
                        FechaRecepcion = c.DateTime(nullable: false, storeType: "date"),
                        FechaEntrega = c.DateTime(storeType: "date"),
                        Equipo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Observaciones = c.String(nullable: false, maxLength: 250, unicode: false),
                        Referencia = c.String(maxLength: 11, unicode: false),
                        TipoPago = c.Int(),
                        Status = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.IdCliente)
                .Index(t => t.IdCliente);
            
            CreateTable(
                "dbo.OrdenHistorial",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdOrden = c.Int(nullable: false),
                        FechaStatus = c.DateTime(nullable: false, storeType: "date"),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orden", t => t.IdOrden)
                .Index(t => t.IdOrden);
            
            CreateTable(
                "dbo.OrdenMecanico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdOrden = c.Int(nullable: false),
                        IdMecanico = c.Int(nullable: false),
                        CostoManoObra = c.Decimal(nullable: false, precision: 12, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mecanico", t => t.IdMecanico)
                .ForeignKey("dbo.Orden", t => t.IdOrden)
                .Index(t => t.IdOrden)
                .Index(t => t.IdMecanico);
            
            CreateTable(
                "dbo.Mecanico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrdenRefaccion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdOrden = c.Int(nullable: false),
                        IdRefaccion = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 12, scale: 2),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Refaccion", t => t.IdRefaccion)
                .ForeignKey("dbo.Orden", t => t.IdOrden)
                .Index(t => t.IdOrden)
                .Index(t => t.IdRefaccion);
            
            CreateTable(
                "dbo.Refaccion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 50, unicode: false),
                        PrecioMinimo = c.Decimal(nullable: false, precision: 10, scale: 2),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrdenRefaccionGarantia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdOrden = c.Int(nullable: false),
                        IdRefaccion = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 12, scale: 2),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Refaccion", t => t.IdRefaccion)
                .ForeignKey("dbo.Orden", t => t.IdOrden)
                .Index(t => t.IdOrden)
                .Index(t => t.IdRefaccion);
            
            CreateTable(
                "dbo.Permiso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 25, unicode: false),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsuarioPermiso",
                c => new
                    {
                        IdUsuarioPermiso = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        IdPermiso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuarioPermiso)
                .ForeignKey("dbo.Usuario", t => t.IdUsuario, cascadeDelete: true)
                .ForeignKey("dbo.Permiso", t => t.IdPermiso, cascadeDelete: true)
                .Index(t => t.IdUsuario)
                .Index(t => t.IdPermiso);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 25, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuarioPermiso", "IdPermiso", "dbo.Permiso");
            DropForeignKey("dbo.UsuarioPermiso", "IdUsuario", "dbo.Usuario");
            DropForeignKey("dbo.Orden", "IdCliente", "dbo.Cliente");
            DropForeignKey("dbo.OrdenRefaccionGarantia", "IdOrden", "dbo.Orden");
            DropForeignKey("dbo.OrdenRefaccion", "IdOrden", "dbo.Orden");
            DropForeignKey("dbo.OrdenRefaccionGarantia", "IdRefaccion", "dbo.Refaccion");
            DropForeignKey("dbo.OrdenRefaccion", "IdRefaccion", "dbo.Refaccion");
            DropForeignKey("dbo.OrdenMecanico", "IdOrden", "dbo.Orden");
            DropForeignKey("dbo.OrdenMecanico", "IdMecanico", "dbo.Mecanico");
            DropForeignKey("dbo.OrdenHistorial", "IdOrden", "dbo.Orden");
            DropIndex("dbo.UsuarioPermiso", new[] { "IdPermiso" });
            DropIndex("dbo.UsuarioPermiso", new[] { "IdUsuario" });
            DropIndex("dbo.OrdenRefaccionGarantia", new[] { "IdRefaccion" });
            DropIndex("dbo.OrdenRefaccionGarantia", new[] { "IdOrden" });
            DropIndex("dbo.OrdenRefaccion", new[] { "IdRefaccion" });
            DropIndex("dbo.OrdenRefaccion", new[] { "IdOrden" });
            DropIndex("dbo.OrdenMecanico", new[] { "IdMecanico" });
            DropIndex("dbo.OrdenMecanico", new[] { "IdOrden" });
            DropIndex("dbo.OrdenHistorial", new[] { "IdOrden" });
            DropIndex("dbo.Orden", new[] { "IdCliente" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Usuario");
            DropTable("dbo.UsuarioPermiso");
            DropTable("dbo.Permiso");
            DropTable("dbo.OrdenRefaccionGarantia");
            DropTable("dbo.Refaccion");
            DropTable("dbo.OrdenRefaccion");
            DropTable("dbo.Mecanico");
            DropTable("dbo.OrdenMecanico");
            DropTable("dbo.OrdenHistorial");
            DropTable("dbo.Orden");
            DropTable("dbo.Cliente");
        }
    }
}
