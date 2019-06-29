namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsFullyPaidFieldToMembershipsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memberships", "IsFullyPaid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Memberships", "IsFullyPaid");
        }
    }
}
