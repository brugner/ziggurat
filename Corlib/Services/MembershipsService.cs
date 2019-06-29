using Corlib.Core;
using Corlib.Factories;
using Corlib.Services.Contracts;
using System;

namespace Corlib.Services
{
   public class MembershipsService : IMembershipsService
   {
      private IUnitOfWork _unitOfWork;

      public void DeactivateExpiredMemberships()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var memberships = _unitOfWork.Memberships.Find(x => x.Status == MembershipStatus.ACTIVE && x.EndDate < DateTime.Today);

            foreach (var membership in memberships)
               membership.Status = MembershipStatus.EXPIRED;

            _unitOfWork.Complete();
         }
      }
   }
}
