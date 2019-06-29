using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
    class ContactModelConfiguration : EntityTypeConfiguration<Contact>
    {
        public ContactModelConfiguration()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.PhoneNumber1).IsRequired().HasMaxLength(50);
            Property(x => x.PhoneNumber2).IsOptional().HasMaxLength(50);
        }
    }
}
