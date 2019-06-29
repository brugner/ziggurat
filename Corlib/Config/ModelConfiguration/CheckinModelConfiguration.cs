using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class CheckinModelConfiguration : EntityTypeConfiguration<Checkin>
   {
      public CheckinModelConfiguration()
      {
         Property(x => x.MembershipId).IsRequired();
         Property(x => x.Date).IsRequired();
      }
   }
}
