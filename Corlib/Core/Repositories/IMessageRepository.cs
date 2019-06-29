using Corlib.Core.Domain;
using System.Collections.Generic;

namespace Corlib.Core.Repositories
{
   internal interface IMessageRepository : IRepository<Message>
   {
      IEnumerable<Message> GetMessages();
      IEnumerable<Message> GetUnreadMessagesToMember(int id);
   }
}
