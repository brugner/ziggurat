namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSkinColumnToParametersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parameters", "Skin", c => c.String(nullable: false, maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parameters", "Skin");
        }
    }
}
