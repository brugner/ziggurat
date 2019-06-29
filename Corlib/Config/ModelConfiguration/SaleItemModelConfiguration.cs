using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class SaleItemModelConfiguration : EntityTypeConfiguration<SaleItem>
   {
      public SaleItemModelConfiguration()
      {
         Property(x => x.SaleId).IsRequired();
         Property(x => x.ProductId).IsRequired();
         Property(x => x.Price).IsRequired().HasPrecision(6, 2);
         Property(x => x.Quantity).IsRequired();
      }
   }
}
