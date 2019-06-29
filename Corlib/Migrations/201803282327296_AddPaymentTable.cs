namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MembershipId = c.Int(),
                        SaleId = c.Int(),
                        Amount = c.Decimal(nullable: false, precision: 6, scale: 2),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Memberships", t => t.MembershipId)
                .Index(t => t.MembershipId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Payments", new[] { "MembershipId" });
            DropTable("dbo.Payments");
        }
    }
}
