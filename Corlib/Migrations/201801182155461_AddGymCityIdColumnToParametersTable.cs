namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGymCityIdColumnToParametersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parameters", "GymCityId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parameters", "GymCityId");
        }
    }
}
