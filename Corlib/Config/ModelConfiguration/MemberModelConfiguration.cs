using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class MemberModelConfiguration : EntityTypeConfiguration<Member>
   {
      public MemberModelConfiguration()
      {
         Property(x => x.DNI).IsRequired();
         HasIndex(x => x.DNI).IsUnique();
         Property(x => x.FirstName).IsRequired().HasMaxLength(50);
         Property(x => x.LastName).IsRequired().HasMaxLength(50);
         Property(x => x.DateOfBirth).IsRequired();
         Property(x => x.Gender).HasMaxLength(1).IsRequired();
         Property(x => x.Address).HasMaxLength(50);
         Property(x => x.MobilePhoneAreaCode).IsOptional();
         Property(x => x.MobilePhoneNumber).IsOptional();
         Property(x => x.HomePhone).HasMaxLength(50);
         Property(x => x.Email).HasMaxLength(50);
         Property(x => x.Occupation).HasMaxLength(50);
         Property(x => x.Organization).HasMaxLength(50);
         Property(x => x.Conditions).HasMaxLength(100);
         Property(x => x.Medicine).HasMaxLength(100);
         Property(x => x.HomePhone).HasMaxLength(50);
         Property(x => x.OtherSports).HasMaxLength(50);
         Property(x => x.Lead).HasMaxLength(50);
         Property(x => x.ProfilePicturePath).HasMaxLength(500);
      }
   }
}
