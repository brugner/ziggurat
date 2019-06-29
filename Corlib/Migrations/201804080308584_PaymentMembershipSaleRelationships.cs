namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentMembershipSaleRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Payments", new[] { "MembershipId" });
            AddColumn("dbo.Payments", "SaleId", c => c.Int());
            AlterColumn("dbo.Payments", "MembershipId", c => c.Int());
            CreateIndex("dbo.Payments", "MembershipId");
            CreateIndex("dbo.Payments", "SaleId");
            AddForeignKey("dbo.Payments", "SaleId", "dbo.Sales", "Id");
            AddForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships");
            DropForeignKey("dbo.Payments", "SaleId", "dbo.Sales");
            DropIndex("dbo.Payments", new[] { "SaleId" });
            DropIndex("dbo.Payments", new[] { "MembershipId" });
            AlterColumn("dbo.Payments", "MembershipId", c => c.Int(nullable: false));
            DropColumn("dbo.Payments", "SaleId");
            CreateIndex("dbo.Payments", "MembershipId");
            AddForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships", "Id", cascadeDelete: true);
        }
    }
}
