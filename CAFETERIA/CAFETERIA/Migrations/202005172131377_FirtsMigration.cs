namespace CAFETERIA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirtsMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Imagen", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Imagen");
        }
    }
}
