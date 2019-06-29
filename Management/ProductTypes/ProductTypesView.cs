using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Management.ProductTypes
{
   public partial class ProductTypesView : XtraForm, IProductTypesView
   {
      public ProductTypesView()
      {
         InitializeComponent();
      }

      #region IProductTypesView
      public IEnumerable<ProductTypeViewModel> ProductTypes
      {
         get { return (IEnumerable<ProductTypeViewModel>)gridControlProductTypes.DataSource; }
         set { gridControlProductTypes.DataSource = value; }
      }

      private int? _id;
      public int? Id
      {
         get { return _id; }
         set { _id = value; }
      }

      public string ProductTypeName
      {
         get { return txtName.Text; }
         set { txtName.Text = value; }
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

      public event Action SaveProductType;
      #endregion

      private void ProductTypesView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void gridViewProductTypes_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
      {
         var productType = GetSelectedProductType();

         if (productType != null)
         {
            Id = productType.Id;
            txtName.Text = productType.Name;
            linkEdit.Enabled = true;
         }
         else
         {
            Id = null;
            txtName.Clear();
            linkEdit.Enabled = false;
         }
      }

      #region Helpers
      private ProductTypeViewModel GetSelectedProductType()
      {
         if (gridControlProductTypes.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlProductTypes.MainView).GetSelectedRows().First();
         var selectedProductType = (ProductTypeViewModel)(((GridView)gridControlProductTypes.MainView).GetRow(selectedRow));
         return selectedProductType;
      }
      #endregion

      private void linkNew_Click(object sender, EventArgs e)
      {
         linkNew.Visible = false;
         linkEdit.Visible = false;
         txtName.ReadOnly = false;
         txtName.Clear();
         btnOK.Enabled = true;
         btnCancel.Enabled = true;
         txtName.Select();

         Id = null;
      }

      private void linkEdit_Click(object sender, EventArgs e)
      {
         linkNew.Visible = false;
         linkEdit.Visible = false;
         txtName.ReadOnly = false;
         txtName.Select();
         btnOK.Enabled = true;
         btnCancel.Enabled = true;
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
         {
            SaveProductType();
            btnCancel_Click(null, null);
         }
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         txtName.ReadOnly = true;
         gridViewProductTypes_FocusedRowChanged(null, new FocusedRowChangedEventArgs(0, 0));
         btnOK.Enabled = false;
         btnCancel.Enabled = false;
         linkNew.Visible = true;
         linkEdit.Visible = true;
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(gbProductTypeData.Controls))
            return false;

         return true;
      }

      private void txtName_Validating(object sender, CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
         {
            errorProvider.SetError(txtName, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtName, string.Empty);
      }
      #endregion
   }
}