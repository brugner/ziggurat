using Corlib.Core.Domain;
using Corlib.Core.Repositories;

namespace Corlib.Persistence.Repositories
{
   internal class NoteRepository : Repository<Note>, INoteRepository
   {
		public ZigguratContext ZigguratContext { get { return Context as ZigguratContext; } }

		public NoteRepository(ZigguratContext context) : base(context)
      {
			
      }
   }
}
