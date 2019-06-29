namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentMembershipRelationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Payments", new[] { "MembershipId" });
            AlterColumn("dbo.Payments", "MembershipId", c => c.Int(nullable: false));
            CreateIndex("dbo.Payments", "MembershipId");
            AddForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Payments", new[] { "MembershipId" });
            AlterColumn("dbo.Payments", "MembershipId", c => c.Int());
            CreateIndex("dbo.Payments", "MembershipId");
            AddForeignKey("dbo.Payments", "MembershipId", "dbo.Memberships", "Id");
        }
    }
}
