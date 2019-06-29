namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParametersGymData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parameters", "GymAddress", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Parameters", "GymPhone", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Parameters", "GymEmail", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Parameters", "GymFacebook", c => c.String(maxLength: 75));
            AddColumn("dbo.Parameters", "GymTwitter", c => c.String(maxLength: 75));
            AddColumn("dbo.Parameters", "GymInstagram", c => c.String(maxLength: 75));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parameters", "GymInstagram");
            DropColumn("dbo.Parameters", "GymTwitter");
            DropColumn("dbo.Parameters", "GymFacebook");
            DropColumn("dbo.Parameters", "GymEmail");
            DropColumn("dbo.Parameters", "GymPhone");
            DropColumn("dbo.Parameters", "GymAddress");
        }
    }
}
