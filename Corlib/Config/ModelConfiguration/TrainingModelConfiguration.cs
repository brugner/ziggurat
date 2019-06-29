using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class TrainingModelConfiguration : EntityTypeConfiguration<Training>
   {
      public TrainingModelConfiguration()
      {
         Property(x => x.Name).IsRequired().HasMaxLength(50);
         Property(x => x.ClassPrice).HasPrecision(5, 2);
         Property(x => x.WeekPrice).HasPrecision(5, 2);
         Property(x => x.MonthPrice).HasPrecision(5, 2);
         Property(x => x.QuarterPrice).HasPrecision(6, 2);
         Property(x => x.IsDeleted).IsRequired();
      }
   }
}
