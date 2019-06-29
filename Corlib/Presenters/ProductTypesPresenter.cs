using AutoMapper;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System.Collections.Generic;

namespace Corlib.Presenters
{
   class ProductTypesPresenter : IProductTypesPresenter
   {
      private readonly IProductTypesView _view;
      private IUnitOfWork _unitOfWork;

      public ProductTypesPresenter(IProductTypesView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         RefreshProductTypesList();
      }

      #region IProductTypesPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void WireViewEvents()
      {
         _view.SaveProductType += OnSaveProductType;
      }

      private void OnSaveProductType()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            ProductType productType = null;

            if (_view.Id.HasValue)
               productType = _unitOfWork.ProductTypes.Get(_view.Id.Value);
            else
               productType = new ProductType();

            productType.Name = _view.ProductTypeName;

            if (!_view.Id.HasValue)
               _unitOfWork.ProductTypes.Add(productType);

            _unitOfWork.Complete();
            _view.Notify("El tipo de producto se guardó exitosamente", MessageType.Information);
            RefreshProductTypesList();
         }
      }

      private void RefreshProductTypesList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var productTypes = _unitOfWork.ProductTypes.GetAll();
            _view.ProductTypes = Mapper.Map<IEnumerable<ProductTypeViewModel>>(productTypes);
         }
      }
   }
}
