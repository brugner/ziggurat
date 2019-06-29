namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDeletedFieldsToTrainingsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Trainings", "DeletedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainings", "DeletedAt");
            DropColumn("dbo.Trainings", "IsDeleted");
        }
    }
}
