using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class PaymentModelConfiguration : EntityTypeConfiguration<Payment>
   {
      public PaymentModelConfiguration()
      {
         //Property(x => x.MembershipId).IsRequired();
         //Property(x => x.SaleId).IsOptional();

         Property(x => x.Concept).HasMaxLength(200);
         Property(x => x.Amount).IsRequired().HasPrecision(6, 2);
         Property(x => x.Date).IsRequired();
         Property(x => x.Comment).HasMaxLength(50);
      }
   }
}
