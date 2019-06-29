namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuotaToShiftsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shifts", "Quota", c => c.Byte());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shifts", "Quota");
        }
    }
}
