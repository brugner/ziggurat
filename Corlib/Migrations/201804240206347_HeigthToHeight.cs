namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HeigthToHeight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonalTrainingRecords", "Height", c => c.Int());
            DropColumn("dbo.PersonalTrainingRecords", "Heigth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonalTrainingRecords", "Heigth", c => c.Int());
            DropColumn("dbo.PersonalTrainingRecords", "Height");
        }
    }
}
