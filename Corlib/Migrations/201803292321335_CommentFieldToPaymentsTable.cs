namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentFieldToPaymentsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "Comment", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "Comment");
        }
    }
}
