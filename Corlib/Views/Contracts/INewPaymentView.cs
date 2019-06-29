using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface INewPaymentView : IView
   {
      string ViewText { set; }
      IEnumerable<DebtViewModel> Debts { get; set; }
      DebtViewModel CheckedDebt { get; set; }
      decimal Amount { get; set; }
      DateTime Date { get; set; }
      string Comment { get; set; }

      void InitializeView();

      event Action SavePayment;
   }
}
