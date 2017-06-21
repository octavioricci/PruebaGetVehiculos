namespace PruebaGetVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        VehiculoPrincipal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Vehiculoes",
                c => new
                    {
                        VehiculoId = c.Int(nullable: false, identity: true),
                        Patente = c.String(),
                        Modelo = c.String(),
                        Cliente_ClienteId = c.Int(),
                    })
                .PrimaryKey(t => t.VehiculoId)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ClienteId)
                .Index(t => t.Cliente_ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehiculoes", "Cliente_ClienteId", "dbo.Clientes");
            DropIndex("dbo.Vehiculoes", new[] { "Cliente_ClienteId" });
            DropTable("dbo.Vehiculoes");
            DropTable("dbo.Clientes");
        }
    }
}
