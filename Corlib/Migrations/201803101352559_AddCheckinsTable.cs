namespace Corlib.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class AddCheckinsTable : DbMigration
   {
      public override void Up()
      {
         CreateTable(
             "dbo.Checkins",
             c => new
             {
                Id = c.Int(nullable: false, identity: true),
                MembershipId = c.Int(nullable: false),
                DateTime = c.DateTime(nullable: false),
             })
             .PrimaryKey(t => t.Id)
             .ForeignKey("dbo.Memberships", t => t.MembershipId, cascadeDelete: false)
             .Index(t => t.MembershipId);

      }

      public override void Down()
      {
         DropForeignKey("dbo.Checkins", "MembershipId", "dbo.Memberships");
         DropIndex("dbo.Checkins", new[] { "MembershipId" });
         DropTable("dbo.Checkins");
      }
   }
}
