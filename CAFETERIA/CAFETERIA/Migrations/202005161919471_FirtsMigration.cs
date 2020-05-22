namespace CAFETERIA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirtsMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "OrderID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "OrderID", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Status");
        }
    }
}
