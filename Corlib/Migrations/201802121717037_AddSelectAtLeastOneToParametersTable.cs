namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSelectAtLeastOneToParametersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parameters", "SelectAtLeastOne", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parameters", "SelectAtLeastOne");
        }
    }
}
