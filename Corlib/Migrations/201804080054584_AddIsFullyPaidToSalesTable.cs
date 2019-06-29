namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsFullyPaidToSalesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "IsFullyPaid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "IsFullyPaid");
        }
    }
}
