using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class SaleModelConfiguration : EntityTypeConfiguration<Sale>
   {
      public SaleModelConfiguration()
      {
         Property(x => x.MemberId).IsRequired();
         Property(x => x.Number).IsRequired();
         Property(x => x.Date).IsRequired();
         Property(x => x.Comment).HasMaxLength(100);
      }
   }
}
