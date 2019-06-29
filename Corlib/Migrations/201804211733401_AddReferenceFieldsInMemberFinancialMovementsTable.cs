namespace Corlib.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class AddReferenceFieldsInMemberFinancialMovementsTable : DbMigration
   {
      public override void Up()
      {
         AddColumn("dbo.MemberFinancialMovements", "MembershipId", c => c.Int());
         AddColumn("dbo.MemberFinancialMovements", "SaleId", c => c.Int());
         AddColumn("dbo.MemberFinancialMovements", "PaymentId", c => c.Int());
      }

      public override void Down()
      {
         DropColumn("dbo.MemberFinancialMovements", "PaymentId");
         DropColumn("dbo.MemberFinancialMovements", "SaleId");
         DropColumn("dbo.MemberFinancialMovements", "MembershipId");
      }
   }
}
