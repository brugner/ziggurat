using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class ShiftModelConfiguration : EntityTypeConfiguration<Shift>
   {
      public ShiftModelConfiguration()
      {
         Property(x => x.Number).IsRequired();
         Property(x => x.InternalDays).IsRequired().HasMaxLength(15);
         Property(x => x.StartTime).IsRequired();
         Property(x => x.EndTime).IsRequired();
      }
   }
}