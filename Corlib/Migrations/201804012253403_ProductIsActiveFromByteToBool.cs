namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductIsActiveFromByteToBool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "IsActive", c => c.Byte(nullable: false));
        }
    }
}
