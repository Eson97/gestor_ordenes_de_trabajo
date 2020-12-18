namespace GestorOrdenesDeTrabajo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrdenMecanico", "CostoManoObra", c => c.Decimal(nullable: false, precision: 12, scale: 2));
            AlterColumn("dbo.OrdenRefaccion", "PrecioUnitario", c => c.Decimal(nullable: false, precision: 12, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrdenRefaccion", "PrecioUnitario", c => c.Decimal(nullable: false, precision: 4, scale: 2));
            AlterColumn("dbo.OrdenMecanico", "CostoManoObra", c => c.Decimal(nullable: false, precision: 4, scale: 2));
        }
    }
}
