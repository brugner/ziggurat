using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class NoteModelConfiguration : EntityTypeConfiguration<Note>
   {
      public NoteModelConfiguration()
      {
         Property(x => x.Text).IsRequired().HasMaxLength(140);
         Property(x => x.Date).IsRequired();
      }
   }
}
