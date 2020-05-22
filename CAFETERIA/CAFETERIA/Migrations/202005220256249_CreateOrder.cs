namespace CAFETERIA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ClientName", c => c.String());
            AddColumn("dbo.Orders", "DireccionClient", c => c.String());
            AddColumn("dbo.Orders", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Total");
            DropColumn("dbo.Orders", "DireccionClient");
            DropColumn("dbo.Orders", "ClientName");
        }
    }
}
