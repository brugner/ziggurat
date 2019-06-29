using AutoMapper;
using Corlib.Builders;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Corlib.Presenters
{
   class NewSalePresenter : INewSalePresenter
   {
      private readonly INewSaleView _view;
      private IUnitOfWork _unitOfWork;
      private MemberViewModel _memberViewModel;

      public NewSalePresenter(INewSaleView view, MemberViewModel memberViewModel)
      {
         _view = view;
         _memberViewModel = memberViewModel;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadRelatedData();
      }

      #region INewSalePresenter
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
         _view.MemberSearch += OnMemberSearch;
         _view.AddItemToBasket += OnAddItemToBasket;
         _view.RemoveItemFromBasket += OnRemoveItemFromBasket;
         _view.SaveSale += OnSaveSale;
      }

      private void OnMemberSearch()
      {
         var presenter = PresenterBuilder<IMemberSearchPresenter, IMemberSearchView>.Build();
         presenter.ShowView();

         _memberViewModel = presenter.SelectedMember;
         LoadViewData();
      }

      private void OnAddItemToBasket(EventArgs<ProductViewModel> e)
      {
         if (_view.SaleItems != null)
            foreach (var item in _view.SaleItems?.ToList())
               if (item.ProductId == e.Value.Id) return;

         byte? quantity = _view.AskForQuantity();

         if (!quantity.HasValue)
            return;

         var items = _view.SaleItems?.ToList() ?? new List<SaleItemViewModel>();

         var newItem = new SaleItemViewModel();
         newItem.ProductId = e.Value.Id;
         newItem.ProductName = e.Value.Name;
         newItem.Price = e.Value.Price;
         newItem.Quantity = quantity.Value;
         newItem.Subtotal = newItem.Price * newItem.Quantity;

         items.Add(newItem);

         _view.SaleItems = items;
      }

      private void OnRemoveItemFromBasket(EventArgs<SaleItemViewModel> e)
      {
         var addedItems = _view.SaleItems?.ToList() ?? new List<SaleItemViewModel>();
         var itemsToRemove = new List<SaleItemViewModel>();

         foreach (var item in addedItems)
            if (item.ProductId == e.Value.ProductId)
               itemsToRemove.Add(item);

         foreach (var itemToRemove in itemsToRemove)
            addedItems.Remove(itemToRemove);

         _view.SaleItems = addedItems;
      }

      private void OnSaveSale()
      {
         ServiceLocator.RunnerService.Run(() =>
         {
            using (var scope = new TransactionScope(TransactionScopeOption.Required))
            {
               using (_unitOfWork = UnitOfWorkFactory.Create())
               {
                  var sale = new Sale();
                  sale.Number = _unitOfWork.Sales.GetNewNumber();
                  sale.MemberId = _view.Member.Id;
                  sale.Date = _view.Date;
                  sale.Comment = _view.Comment;
                  _unitOfWork.Sales.Add(sale);

                  sale.SaleItems = new List<SaleItem>();

                  foreach (var selectedItem in _view.SaleItems)
                  {
                     var item = new SaleItem();
                     item.Sale = sale;
                     item.ProductId = selectedItem.ProductId;
                     item.Price = selectedItem.Price;
                     item.Quantity = selectedItem.Quantity;
                     _unitOfWork.SaleItems.Add(item);
                  }

                  _unitOfWork.Complete();

                  var financialService = new FinancialService(_unitOfWork);
                  financialService.RegisterMovement(sale.MemberId, $"Venta #{sale.Number}", debit: sale.SaleItems.Sum(x => x.Price * x.Quantity), credit: 0, saleId: sale.Id);

                  _unitOfWork.Complete();
               }

               scope.Complete();
               _view.Notify("La venta se registró exitosamente", MessageType.Information);
               _view.CloseView();
            }
         }, "Ha ocurrido un error al intentar registrar la venta. Por favor, intenta nuevamente.");
      }

      #region Helpers
      public void LoadRelatedData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var products = _unitOfWork.Products.Find(x => x.IsActive, "ProductType");
            var productsViewModels = Mapper.Map<IEnumerable<ProductViewModel>>(products);

            _view.Products = productsViewModels;
         }
      }

      private void LoadViewData()
      {
         if (_memberViewModel == null)
         {
            ClearView();
            return;
         }

         _view.Member = _memberViewModel;
      }

      private void ClearView()
      {
         _view.Member = null;
      }
      #endregion
   }
}
