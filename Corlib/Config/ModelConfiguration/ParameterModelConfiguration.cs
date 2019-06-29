using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class ParameterModelConfiguration : EntityTypeConfiguration<Parameter>
   {
      public ParameterModelConfiguration()
      {
         Property(x => x.GymName).IsRequired().HasMaxLength(50);
         Property(x => x.GymAddress).IsRequired().HasMaxLength(50);
         Property(x => x.GymCityId).IsRequired();
         Property(x => x.GymPhone).IsRequired().HasMaxLength(50);
         Property(x => x.GymEmail).IsRequired().HasMaxLength(50);
         Property(x => x.GymFacebook).HasMaxLength(75);
         Property(x => x.GymTwitter).HasMaxLength(75);
         Property(x => x.GymInstagram).HasMaxLength(75);

         Property(x => x.RequiredField).IsRequired().HasMaxLength(50);
         Property(x => x.InvalidEmailAddress).IsRequired().HasMaxLength(50);
         Property(x => x.EnterAtLeastAPhone).IsRequired().HasMaxLength(50);
         Property(x => x.EnterMobilePhoneAreaCode).IsRequired().HasMaxLength(50);
         Property(x => x.EnterPhoneNumber).IsRequired().HasMaxLength(50);
         Property(x => x.SelectAtLeastOne).IsRequired().HasMaxLength(50);
         Property(x => x.Skin).IsRequired().HasMaxLength(25);
         Property(x => x.SplitContainerMembersVerticalSplitterPosition).IsRequired();
         Property(x => x.SplitContainerMembersHorizontalSplitterPosition).IsRequired();
      }
   }
}
