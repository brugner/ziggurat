namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdText = c.String(maxLength: 140),
                        Image1Path = c.String(maxLength: 500),
                        Image1SizeMode = c.Byte(nullable: false),
                        Image2Path = c.String(maxLength: 500),
                        Image2SizeMode = c.Byte(nullable: false),
                        Image3Path = c.String(maxLength: 500),
                        Image3SizeMode = c.Byte(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ads");
        }
    }
}
