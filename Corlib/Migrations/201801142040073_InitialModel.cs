namespace Corlib.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 30),
                    ZipCode = c.String(maxLength: 10),
                    StateId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: false)
                .Index(t => t.StateId);

            CreateTable(
                "dbo.Members",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DNI = c.Int(nullable: false),
                    FirstName = c.String(nullable: false, maxLength: 50),
                    LastName = c.String(nullable: false, maxLength: 50),
                    DateOfBirth = c.DateTime(nullable: false),
                    Gender = c.String(nullable: false, maxLength: 1),
                    Address = c.String(maxLength: 50),
                    CityId = c.Int(nullable: false),
                    MobilePhoneAreaCode = c.Int(),
                    MobilePhoneNumber = c.Long(),
                    HomePhone = c.String(maxLength: 50),
                    Email = c.String(maxLength: 50),
                    Occupation = c.String(maxLength: 50),
                    Organization = c.String(maxLength: 50),
                    Conditions = c.String(maxLength: 100),
                    Medicine = c.String(maxLength: 100),
                    Smoke = c.Boolean(nullable: false),
                    Alcohol = c.Boolean(nullable: false),
                    Diet = c.Boolean(nullable: false),
                    IsFirstTimeAtGym = c.Boolean(nullable: false),
                    OtherSports = c.String(maxLength: 50),
                    IsStudying = c.Boolean(nullable: false),
                    IsWorking = c.Boolean(nullable: false),
                    Lead = c.String(maxLength: 50),
                    JoiningDate = c.DateTime(nullable: false),
                    UpdatedAt = c.DateTime(nullable: false),
                    IsDeleted = c.Boolean(nullable: false),
                    DeletedAt = c.DateTime(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: false)
                .Index(t => t.DNI, unique: true)
                .Index(t => t.CityId);

            CreateTable(
                "dbo.States",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 20),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(nullable: false, maxLength: 30),
                    PasswordHash = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Cities", "StateId", "dbo.States");
            DropForeignKey("dbo.Members", "CityId", "dbo.Cities");
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Members", new[] { "CityId" });
            DropIndex("dbo.Members", new[] { "DNI" });
            DropIndex("dbo.Cities", new[] { "StateId" });
            DropTable("dbo.Users");
            DropTable("dbo.States");
            DropTable("dbo.Members");
            DropTable("dbo.Cities");
        }
    }
}
