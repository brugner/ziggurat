namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatabaseBackupRecords : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatabaseBackupRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Path = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DatabaseBackupRecords");
        }
    }
}
