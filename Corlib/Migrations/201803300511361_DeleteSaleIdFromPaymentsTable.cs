namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSaleIdFromPaymentsTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Payments", "SaleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "SaleId", c => c.Int());
        }
    }
}
