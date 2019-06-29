using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class MessageModelConfiguration : EntityTypeConfiguration<Message>
   {
      public MessageModelConfiguration()
      {
         Property(x => x.InternalRecipients).IsRequired().HasMaxLength(5000);
         Property(x => x.Subject).IsRequired().HasMaxLength(50);
         Property(x => x.Body).IsRequired().HasMaxLength(200);
         Property(x => x.Date).IsRequired();
         Property(x => x.InternalReadBy).HasMaxLength(5000);
      }
   }
}