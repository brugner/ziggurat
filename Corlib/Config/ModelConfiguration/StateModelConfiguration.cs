using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
    class StateModelConfiguration : EntityTypeConfiguration<State>
    {
        public StateModelConfiguration()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(20);
        }
    }
}