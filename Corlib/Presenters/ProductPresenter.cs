using AutoMapper;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using NLog;
using System;
using System.Collections.Generic;

namespace Corlib.Presenters
{
   class ProductPresenter : IProductPresenter
   {
      private readonly IProductView _view;
      private IUnitOfWork _unitOfWork;
      private Product _product;
      private bool _isNewProduct;
      private static Logger _logger = LogManager.GetCurrentClassLogger();

      public ProductPresenter(IProductView view, ProductViewModel productViewModel)
      {
         _view = view;
         _isNewProduct = productViewModel == null;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadRelatedData();

         if (_isNewProduct)
            PrepareViewForNewProduct();
         else
            ShowProductData(productViewModel);
      }

      #region IProductPresenter
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
         _view.SaveProduct += OnSaveProduct;
      }

      private void OnSaveProduct()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            if (_isNewProduct)
               _product = new Product();
            else
               _product = _unitOfWork.Products.Get(_view.Id.Value);

            _product.Name = _view.ProductModelName;
            _product.Price = _view.Price;
            _product.Cost = _view.Cost;
            _product.ProductTypeId = _view.ProductType.Id;
            _product.IsActive = _view.IsProductActive;
            _product.UpdatedAt = DateTime.Now;

            if (_isNewProduct)
            {
               _product.CreatedAt = DateTime.Now;
               _unitOfWork.Products.Add(_product);
            }

            ServiceLocator.RunnerService.Run(() =>
            {
               _unitOfWork.Complete();
               _view.Notify("El producto se guardó exitosamente", MessageType.Information);
               _view.CloseView();
            }, "Ha ocurrido un error al intentar guardar el producto. Por favor, intenta nuevamente.");
         }
      }

      #region Helpers
      private void ShowProductData(ProductViewModel productViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _product = _unitOfWork.Products.Get(x => x.Id == productViewModel.Id, "ProductType");
         }

         _view.Id = _product.Id;
         _view.ProductModelName = _product.Name;
         _view.Price = _product.Price;
         _view.Cost = _product.Cost;
         _view.ProductType = Mapper.Map<ProductTypeViewModel>(_product.ProductType);
         _view.IsProductActive = _product.IsActive;
         _view.CreatedAt = _product.CreatedAt;
         _view.UpdatedAt = _product.UpdatedAt;

         _view.ViewText = $"{_product.Name}";
      }

      private void PrepareViewForNewProduct()
      {
         _view.ViewText = "Agregar producto";
      }

      public void LoadRelatedData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var types = _unitOfWork.ProductTypes.GetAll();

            _view.ProductTypes = Mapper.Map<IEnumerable<ProductTypeViewModel>>(types);
         }
      }
      #endregion
   }
}
