namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMessagesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InternalRecipients = c.String(nullable: false),
                        Subject = c.String(nullable: false, maxLength: 50),
                        Body = c.String(nullable: false, maxLength: 200),
                        DateTime = c.DateTime(nullable: false),
                        InternalReadBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
