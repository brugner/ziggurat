using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class MembershipModelConfiguration : EntityTypeConfiguration<Membership>
   {
      public MembershipModelConfiguration()
      {
         Property(x => x.Length).IsRequired();
         Property(x => x.StartDate).IsRequired();
         Property(x => x.EndDate).IsRequired();
         Property(x => x.Price).IsRequired().HasPrecision(6, 2);
         Property(x => x.Status).IsRequired();
      }
   }
}
