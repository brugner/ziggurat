using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class ProductModelConfiguration : EntityTypeConfiguration<Product>
   {
      public ProductModelConfiguration()
      {
         Property(x => x.Name).IsRequired().HasMaxLength(50);
         Property(x => x.Price).IsRequired().HasPrecision(6, 2);
         Property(x => x.Cost).HasPrecision(6, 2);
         Property(x => x.ProductTypeId).IsRequired();
         Property(x => x.CreatedAt).IsRequired();
         Property(x => x.IsActive).IsRequired();
      }
   }
}
