using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IProductView : IView
   {
      string ViewText { set; }
      int? Id { get; set; }
      string ProductModelName { get; set; }
      decimal Price { get; set; }
      decimal Cost { get; set; }
      ProductTypeViewModel ProductType { get; set; }
      bool IsProductActive { get; set; }
      IEnumerable<ProductTypeViewModel> ProductTypes { get; set; }
      DateTime CreatedAt { set; }
      DateTime UpdatedAt { set; }

      event Action SaveProduct;
   }
}
