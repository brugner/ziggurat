using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class AdModelConfiguration : EntityTypeConfiguration<Ad>
   {
      public AdModelConfiguration()
      {
         Property(x => x.AdText).HasMaxLength(1000);
         Property(x => x.Image1Path).HasMaxLength(500);
         Property(x => x.Image2Path).HasMaxLength(500);
         Property(x => x.Image3Path).HasMaxLength(500);
         Property(x => x.StartDate).IsRequired();
         Property(x => x.EndDate).IsRequired();
      }
   }
}
