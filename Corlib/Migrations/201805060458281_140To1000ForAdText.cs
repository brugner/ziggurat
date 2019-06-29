namespace Corlib.Migrations
{
   using System.Data.Entity.Migrations;

   public partial class _140To1000ForAdText : DbMigration
   {
      public override void Up()
      {
         AlterColumn("dbo.Ads", "AdText", c => c.String(maxLength: 1000));
      }

      public override void Down()
      {
         AlterColumn("dbo.Ads", "AdText", c => c.String(maxLength: 140));
      }
   }
}
