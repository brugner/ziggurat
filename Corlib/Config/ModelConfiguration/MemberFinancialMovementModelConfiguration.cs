using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class MemberFinancialMovementModelConfiguration : EntityTypeConfiguration<MemberFinancialMovement>
   {
      public MemberFinancialMovementModelConfiguration()
      {
         Property(x => x.MemberId).IsRequired();
         Property(x => x.Date).IsRequired();
         Property(x => x.Concept).IsRequired().HasMaxLength(500);
         Property(x => x.Debit).IsRequired().HasPrecision(6, 2);
         Property(x => x.Credit).IsRequired().HasPrecision(6, 2);
         Property(x => x.Balance).IsRequired().HasPrecision(6, 2);
      }
   }
}
