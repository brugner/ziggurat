namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSplitContainerMembersSplitterPositionToParametersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parameters", "SplitContainerMembersSplitterPosition", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parameters", "SplitContainerMembersSplitterPosition");
        }
    }
}
