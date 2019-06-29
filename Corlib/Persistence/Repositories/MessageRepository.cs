using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class MessageRepository : Repository<Message>, IMessageRepository
   {
      public ZigguratContext ZigguratContext { get { return Context as ZigguratContext; } }

      public MessageRepository(ZigguratContext context) : base(context)
      {

      }

      public IEnumerable<Message> GetMessages()
      {
         return ZigguratContext.Messages.ToList();
      }

      public IEnumerable<Message> GetUnreadMessagesToMember(int id)
      {
         var allMessages = ZigguratContext.Messages.ToList();
         var messagesToMember = allMessages.Where(x => x.Recipients.Contains(id)).ToList();
         var alreadyReadMessages = new List<Message>();

         foreach (var message in messagesToMember)
            if (message.ReadBy != null && message.ReadBy.Contains(id))
               alreadyReadMessages.Add(message);

         foreach (var message in alreadyReadMessages)
            messagesToMember.Remove(message);

         return messagesToMember;
      }
   }
}
