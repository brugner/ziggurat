namespace Corlib.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddContactsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MemberId = c.Int(nullable: false),
                    Name = c.String(nullable: false, maxLength: 50),
                    PhoneNumber1 = c.String(nullable: false, maxLength: 50),
                    PhoneNumber2 = c.String(maxLength: 50),
                    IsDoctor = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "MemberId", "dbo.Members");
            DropIndex("dbo.Contacts", new[] { "MemberId" });
            DropTable("dbo.Contacts");
        }
    }
}
