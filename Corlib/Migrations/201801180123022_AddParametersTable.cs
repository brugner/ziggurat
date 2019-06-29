namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddParametersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GymName = c.String(nullable: false, maxLength: 50),
                        RequiredField = c.String(nullable: false, maxLength: 50),
                        InvalidEmailAddress = c.String(nullable: false, maxLength: 50),
                        EnterAtLeastAPhone = c.String(nullable: false, maxLength: 50),
                        EnterMobilePhoneAreaCode = c.String(nullable: false, maxLength: 50),
                        EnterPhoneNumber = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parameters");
        }
    }
}
