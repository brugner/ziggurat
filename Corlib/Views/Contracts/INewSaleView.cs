using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface INewSaleView : IView
   {
      MemberViewModel Member { get; set; }
      string Comment { get; }
      DateTime Date { get; }
      IEnumerable<ProductViewModel> Products { get; set; }
      IEnumerable<SaleItemViewModel> SaleItems { get; set; }

      byte? AskForQuantity();

      event Action MemberSearch;
      event Action<EventArgs<ProductViewModel>> AddItemToBasket;
      event Action<EventArgs<SaleItemViewModel>> RemoveItemFromBasket;
      event Action SaveSale;
   }
}
