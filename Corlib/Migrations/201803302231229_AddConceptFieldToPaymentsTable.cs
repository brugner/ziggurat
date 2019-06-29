namespace Corlib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConceptFieldToPaymentsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "Concept", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "Concept");
        }
    }
}
