using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
    class CityModelConfiguration : EntityTypeConfiguration<City>
    {
        public CityModelConfiguration()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(30);
            Property(x => x.ZipCode).HasMaxLength(10);
        }
    }
}