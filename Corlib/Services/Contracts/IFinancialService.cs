namespace Corlib.Services.Contracts
{
   public interface IFinancialService
   {
      void RegisterMovement(int memberId, string concept, decimal debit, decimal credit, int? membershipId = null, int? saleId = null, int? paymentId = null);
   }
}
