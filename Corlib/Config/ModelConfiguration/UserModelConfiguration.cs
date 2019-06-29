using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class UserModelConfiguration : EntityTypeConfiguration<Core.Domain.User>
   {
      public UserModelConfiguration()
      {
         Property(x => x.Username).IsRequired().HasMaxLength(30);
         HasIndex(x => x.Username).IsUnique();
         Property(x => x.PasswordHash).IsRequired().HasMaxLength(256);
      }
   }
}
