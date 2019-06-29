using Corlib.Core;
using Corlib.Persistence;

namespace Corlib.Factories
{
   class UnitOfWorkFactory
   {
      internal static IUnitOfWork Create()
      {
         return new UnitOfWork(new ZigguratContext());
      }
   }
}
