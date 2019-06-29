namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedAndUpdatedAtToTrainingsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Trainings", "UpdatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainings", "UpdatedAt");
            DropColumn("dbo.Trainings", "CreatedAt");
        }
    }
}
