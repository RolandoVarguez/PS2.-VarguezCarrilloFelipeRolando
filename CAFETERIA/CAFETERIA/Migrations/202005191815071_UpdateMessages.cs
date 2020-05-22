namespace CAFETERIA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMessages : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "Precio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Precio", c => c.Int(nullable: false));
        }
    }
}
