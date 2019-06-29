namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShiftsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrainingId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        InternalDays = c.String(),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainings", t => t.TrainingId, cascadeDelete: true)
                .Index(t => t.TrainingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shifts", "TrainingId", "dbo.Trainings");
            DropIndex("dbo.Shifts", new[] { "TrainingId" });
            DropTable("dbo.Shifts");
        }
    }
}
