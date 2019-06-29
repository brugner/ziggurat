using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Management.Sales
{
   public partial class NewSaleView : XtraForm, INewSaleView
   {
      public NewSaleView()
      {
         InitializeComponent();
      }

      #region IMemberView
      private MemberViewModel _member;
      public MemberViewModel Member
      {
         get { return _member; }
         set
         {
            if (value != null)
            {
               txtMemberFullName.Text = value.FullName;
               _member = value;
            }
            else
            {
               txtMemberFullName.Clear();
               _member = null;
            }
         }
      }

      public DateTime Date
      {
         get { return dtpDate.Value; }
      }

      public string Comment
      {
         get { return txtComment.Text; }
      }

      public IEnumerable<ProductViewModel> Products
      {
         get { return (IEnumerable<ProductViewModel>)gridControlProducts.DataSource; }
         set { gridControlProducts.DataSource = value; }
      }

      public IEnumerable<SaleItemViewModel> SaleItems
      {
         get { return (IEnumerable<SaleItemViewModel>)gridControlSaleItems.DataSource; }
         set { gridControlSaleItems.DataSource = value; }
      }

      public void CloseView()
      {
         Close();
      }

      public void Notify(string message, MessageType type)
      {
         var icon = MessageBoxIcon.Information;

         if (type == MessageType.Error)
            icon = MessageBoxIcon.Error;
         else if (type == MessageType.Warning)
            icon = MessageBoxIcon.Exclamation;

         XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OK, icon);
      }

      public bool Confirm(string message)
      {
         return XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
      }

      public void ShowView()
      {
         ShowDialog();
      }

      public byte? AskForQuantity()
      {
         var view = new AskForQuantityView();

         if (view.ShowDialog() == DialogResult.OK)
            return view.Quantity;
         else
            return null;
      }

      public event Action MemberSearch;
      public event Action<EventArgs<ProductViewModel>> AddItemToBasket;
      public event Action<EventArgs<SaleItemViewModel>> RemoveItemFromBasket;
      public event Action SaveSale;
      #endregion

      private void NewSaleView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void linkMemberSearch_Click(object sender, EventArgs e)
      {
         MemberSearch();
      }

      private void gridViewProducts_DoubleClick(object sender, EventArgs e)
      {
         var selectedProduct = GetSelectedProduct();

         if (selectedProduct != null)
            AddItemToBasket(new EventArgs<ProductViewModel>(selectedProduct));

         btnOK.Enabled = gridViewSaleItems.RowCount > 0;
      }

      private void gridViewSaleItems_DoubleClick(object sender, EventArgs e)
      {
         var selectedItem = GetSelectedSaleItem();

         if (selectedItem != null)
            RemoveItemFromBasket(new EventArgs<SaleItemViewModel>(selectedItem));

         btnOK.Enabled = gridViewSaleItems.RowCount > 0;
      }

      #region Helpers
      private ProductViewModel GetSelectedProduct()
      {
         if (gridControlProducts.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlProducts.MainView).GetSelectedRows().First();
         var selectedProduct = (ProductViewModel)(((GridView)gridControlProducts.MainView).GetRow(selectedRow));
         return selectedProduct;
      }

      private SaleItemViewModel GetSelectedSaleItem()
      {
         if (gridControlSaleItems.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlSaleItems.MainView).GetSelectedRows().First();
         var selectedSaleItem = (SaleItemViewModel)(((GridView)gridControlSaleItems.MainView).GetRow(selectedRow));
         return selectedSaleItem;
      }
      #endregion

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SaveSale();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }
      #endregion

      private void txtMemberFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtMemberFullName.Text))
         {
            errorProvider.SetError(txtMemberFullName, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtMemberFullName, string.Empty);
      }
   }
}