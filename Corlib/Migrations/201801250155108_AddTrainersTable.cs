namespace Corlib.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class AddTrainersTable : DbMigration
   {
      public override void Up()
      {
         CreateTable(
             "dbo.Trainers",
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
                JoiningDate = c.DateTime(nullable: false),
                UpdatedAt = c.DateTime(nullable: false),
                IsDeleted = c.Boolean(nullable: false),
                DeletedAt = c.DateTime(),
                ProfilePicturePath = c.String(maxLength: 500),
                ProfilePictureSizeMode = c.Byte(nullable: false),
             })
             .PrimaryKey(t => t.Id)
             .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: false)
             .Index(t => t.DNI, unique: true)
             .Index(t => t.CityId);

      }

      public override void Down()
      {
         DropForeignKey("dbo.Trainers", "CityId", "dbo.Cities");
         DropIndex("dbo.Trainers", new[] { "CityId" });
         DropIndex("dbo.Trainers", new[] { "DNI" });
         DropTable("dbo.Trainers");
      }
   }
}
