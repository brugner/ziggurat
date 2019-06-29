namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfilePicturePathToMembersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "ProfilePicturePath", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "ProfilePicturePath");
        }
    }
}
