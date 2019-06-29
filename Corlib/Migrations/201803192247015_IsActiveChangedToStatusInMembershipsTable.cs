namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActiveChangedToStatusInMembershipsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memberships", "Status", c => c.Byte(nullable: false));
            DropColumn("dbo.Memberships", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Memberships", "IsActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Memberships", "Status");
        }
    }
}
