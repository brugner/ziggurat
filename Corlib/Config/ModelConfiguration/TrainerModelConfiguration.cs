using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class TrainerModelConfiguration : EntityTypeConfiguration<Trainer>
   {
      public TrainerModelConfiguration()
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
         Property(x => x.HomePhone).HasMaxLength(50);
         Property(x => x.ProfilePicturePath).HasMaxLength(500);
      }
   }
}
