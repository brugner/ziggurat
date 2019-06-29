namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfilePictureSizeModeToMembersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "ProfilePictureSizeMode", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "ProfilePictureSizeMode");
        }
    }
}
