namespace Corlib.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class TrainingsTableAndTrainersRelationship : DbMigration
   {
      public override void Up()
      {
         CreateTable(
             "dbo.Trainings",
             c => new
             {
                Id = c.Int(nullable: false, identity: true),
                Name = c.String(nullable: false, maxLength: 50),
                ClassPrice = c.Decimal(nullable: false, precision: 5, scale: 2),
                WeekPrice = c.Decimal(nullable: false, precision: 5, scale: 2),
                MonthPrice = c.Decimal(nullable: false, precision: 5, scale: 2),
             })
             .PrimaryKey(t => t.Id);

         CreateTable(
             "dbo.TrainerTrainings",
             c => new
             {
                Trainer_Id = c.Int(nullable: false),
                Training_Id = c.Int(nullable: false),
             })
             .PrimaryKey(t => new { t.Trainer_Id, t.Training_Id })
             .ForeignKey("dbo.Trainers", t => t.Trainer_Id, cascadeDelete: true)
             .ForeignKey("dbo.Trainings", t => t.Training_Id, cascadeDelete: true)
             .Index(t => t.Trainer_Id)
             .Index(t => t.Training_Id);

      }

      public override void Down()
      {
         DropForeignKey("dbo.TrainerTrainings", "Training_Id", "dbo.Trainings");
         DropForeignKey("dbo.TrainerTrainings", "Trainer_Id", "dbo.Trainers");
         DropIndex("dbo.TrainerTrainings", new[] { "Training_Id" });
         DropIndex("dbo.TrainerTrainings", new[] { "Trainer_Id" });
         DropTable("dbo.TrainerTrainings");
         DropTable("dbo.Trainings");
      }
   }
}
