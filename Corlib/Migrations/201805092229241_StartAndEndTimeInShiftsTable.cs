namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartAndEndTimeInShiftsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shifts", "StartTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Shifts", "EndTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Shifts", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shifts", "Time", c => c.DateTime(nullable: false));
            DropColumn("dbo.Shifts", "EndTime");
            DropColumn("dbo.Shifts", "StartTime");
        }
    }
}
