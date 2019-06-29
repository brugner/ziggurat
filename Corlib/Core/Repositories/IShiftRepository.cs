using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
   internal interface IShiftRepository : IRepository<Shift>
   {
      bool HasFreeQuota(int id);
      byte? GetAvailableQuota(int id);
      byte GetCurrentMembersCount(int id);
   }
}
