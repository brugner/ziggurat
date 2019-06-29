using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class PersonalTrainingRecordModelConfiguration : EntityTypeConfiguration<PersonalTrainingRecord>
   {
      public PersonalTrainingRecordModelConfiguration()
      {
         Property(x => x.MemberId).IsRequired();
         Property(x => x.Date).IsRequired();
         Property(x => x.Comment).HasMaxLength(50);
      }
   }
}
