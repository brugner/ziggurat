using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class ProductTypeModelConfiguration : EntityTypeConfiguration<ProductType>
   {
      public ProductTypeModelConfiguration()
      {
         Property(x => x.Name).IsRequired().HasMaxLength(50);
      }
   }
}
