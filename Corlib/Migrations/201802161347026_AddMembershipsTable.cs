namespace Corlib.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class AddMembershipsTable : DbMigration
   {
      public override void Up()
      {
         CreateTable(
             "dbo.Memberships",
             c => new
             {
                Id = c.Int(nullable: false, identity: true),
                MemberId = c.Int(nullable: false),
                TrainingId = c.Int(nullable: false),
                ShiftId = c.Int(nullable: false),
                Length = c.Int(nullable: false),
                StartDate = c.DateTime(nullable: false),
                EndDate = c.DateTime(nullable: false),
                Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                IsActive = c.Boolean(nullable: false),
             })
             .PrimaryKey(t => t.Id)
             .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: false)
             .ForeignKey("dbo.Shifts", t => t.ShiftId, cascadeDelete: false)
             .ForeignKey("dbo.Trainings", t => t.TrainingId, cascadeDelete: false)
             .Index(t => t.MemberId)
             .Index(t => t.TrainingId)
             .Index(t => t.ShiftId);

      }

      public override void Down()
      {
         DropForeignKey("dbo.Memberships", "TrainingId", "dbo.Trainings");
         DropForeignKey("dbo.Memberships", "ShiftId", "dbo.Shifts");
         DropForeignKey("dbo.Memberships", "MemberId", "dbo.Members");
         DropIndex("dbo.Memberships", new[] { "ShiftId" });
         DropIndex("dbo.Memberships", new[] { "TrainingId" });
         DropIndex("dbo.Memberships", new[] { "MemberId" });
         DropTable("dbo.Memberships");
      }
   }
}
