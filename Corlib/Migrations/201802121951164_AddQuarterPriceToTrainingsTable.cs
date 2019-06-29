namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuarterPriceToTrainingsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "QuarterPrice", c => c.Decimal(nullable: false, precision: 6, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainings", "QuarterPrice");
        }
    }
}
