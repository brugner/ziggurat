namespace Corlib.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class AddMemberFinancialMovementsTable : DbMigration
   {
      public override void Up()
      {
         CreateTable(
             "dbo.MemberFinancialMovements",
             c => new
             {
                Id = c.Int(nullable: false, identity: true),
                MemberId = c.Int(nullable: false),
                Date = c.DateTime(nullable: false),
                Concept = c.String(nullable: false, maxLength: 500),
                Debit = c.Decimal(nullable: false, precision: 6, scale: 2),
                Credit = c.Decimal(nullable: false, precision: 6, scale: 2),
                Balance = c.Decimal(nullable: false, precision: 6, scale: 2),
             })
             .PrimaryKey(t => t.Id)
             .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
             .Index(t => t.MemberId);

      }

      public override void Down()
      {
         DropForeignKey("dbo.MemberFinancialMovements", "MemberId", "dbo.Members");
         DropIndex("dbo.MemberFinancialMovements", new[] { "MemberId" });
         DropTable("dbo.MemberFinancialMovements");
      }
   }
}
