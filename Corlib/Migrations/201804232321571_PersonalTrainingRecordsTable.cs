namespace Corlib.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class PersonalTrainingRecordsTable : DbMigration
   {
      public override void Up()
      {
         CreateTable(
             "dbo.PersonalTrainingRecords",
             c => new
             {
                Id = c.Int(nullable: false, identity: true),
                MemberId = c.Int(nullable: false),
                Date = c.DateTime(nullable: false),
                Weight = c.Int(),
                Heigth = c.Int(),
                Neck = c.Int(),
                Shoulders = c.Int(),
                Chest = c.Int(),
                Waist = c.Int(),
                Forearms = c.Int(),
                Thighs = c.Int(),
                Calves = c.Int(),
                Biceps = c.Int(),
                Buttocks = c.Int(),
                Comment = c.String(maxLength: 50),
             })
             .PrimaryKey(t => t.Id)
             .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
             .Index(t => t.MemberId);

      }

      public override void Down()
      {
         DropForeignKey("dbo.PersonalTrainingRecords", "MemberId", "dbo.Members");
         DropIndex("dbo.PersonalTrainingRecords", new[] { "MemberId" });
         DropTable("dbo.PersonalTrainingRecords");
      }
   }
}
