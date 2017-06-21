namespace PruebaGetVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "VehiculoPrincipalId", c => c.Int(nullable: false));
            DropColumn("dbo.Clientes", "VehiculoPrincipal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "VehiculoPrincipal", c => c.Int(nullable: false));
            DropColumn("dbo.Clientes", "VehiculoPrincipalId");
        }
    }
}
