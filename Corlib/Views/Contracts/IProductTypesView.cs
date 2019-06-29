using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IProductTypesView : IView
   {
      IEnumerable<ProductTypeViewModel> ProductTypes { get; set; }
      int? Id { get; set; }
      string ProductTypeName { get; set; }

      event Action SaveProductType;
   }
}
