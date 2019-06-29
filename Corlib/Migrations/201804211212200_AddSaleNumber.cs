namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSaleNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "Number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "Number");
        }
    }
}
