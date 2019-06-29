namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDateTimeToDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Checkins", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Notes", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Messages", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Checkins", "DateTime");
            DropColumn("dbo.Notes", "DateTime");
            DropColumn("dbo.Messages", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Notes", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Checkins", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Messages", "Date");
            DropColumn("dbo.Notes", "Date");
            DropColumn("dbo.Checkins", "Date");
        }
    }
}
