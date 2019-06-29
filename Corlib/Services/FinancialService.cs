using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Extensions;
using Corlib.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Services
{
   internal class FinancialService : IFinancialService
   {
      private readonly IUnitOfWork _unitOfWork;

      public FinancialService(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
      }

      #region IFinancialService
      public void RegisterMovement(int memberId, string concept, decimal debit, decimal credit, int? membershipId = null, int? saleId = null, int? paymentId = null)
      {
         var movement = new MemberFinancialMovement
         {
            MemberId = memberId,
            Date = DateTime.Now,
            Concept = concept.Truncate(500),
            Debit = debit,
            Credit = credit,
            Balance = GetBalance(memberId, debit >= credit ? FinancialMovementType.Debit : FinancialMovementType.Credit, debit >= credit ? debit : credit),
            MembershipId = membershipId,
            SaleId = saleId,
            PaymentId = paymentId
         };

         _unitOfWork.MemberFinancialMovements.Add(movement);

         var member = _unitOfWork.Members.Get(memberId);
         member.FinancialMovements.Add(movement);
      }
      #endregion

      #region Helpers
      private decimal GetBalance(int memberId, FinancialMovementType type, decimal amount)
      {
         var balance = _unitOfWork.MemberFinancialMovements.GetBalance(memberId);

         if (type == FinancialMovementType.Debit)
            balance += amount;
         else
            balance -= amount;

         return balance;

      }

      internal void DeleteMovement(int memberId, FinancialMovementReference reference, int referenceId)
      {
         var movements = new List<MemberFinancialMovement>().AsEnumerable();

         if (reference == FinancialMovementReference.Membership)
            movements = _unitOfWork.MemberFinancialMovements.Find(x => x.MemberId == memberId && x.MembershipId == referenceId);
         else if (reference == FinancialMovementReference.Sale)
            movements = _unitOfWork.MemberFinancialMovements.Find(x => x.MemberId == memberId && x.SaleId == referenceId);
         else if (reference == FinancialMovementReference.Payment)
            movements = _unitOfWork.MemberFinancialMovements.Find(x => x.MemberId == memberId && x.PaymentId == referenceId);

         _unitOfWork.MemberFinancialMovements.RemoveRange(movements);
      }
      #endregion
   }
}
