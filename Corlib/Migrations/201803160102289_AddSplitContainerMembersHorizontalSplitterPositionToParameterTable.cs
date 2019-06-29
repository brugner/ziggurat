namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSplitContainerMembersHorizontalSplitterPositionToParameterTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parameters", "SplitContainerMembersVerticalSplitterPosition", c => c.Int(nullable: false));
            AddColumn("dbo.Parameters", "SplitContainerMembersHorizontalSplitterPosition", c => c.Int(nullable: false));
            DropColumn("dbo.Parameters", "SplitContainerMembersSplitterPosition");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Parameters", "SplitContainerMembersSplitterPosition", c => c.Int(nullable: false));
            DropColumn("dbo.Parameters", "SplitContainerMembersHorizontalSplitterPosition");
            DropColumn("dbo.Parameters", "SplitContainerMembersVerticalSplitterPosition");
        }
    }
}
