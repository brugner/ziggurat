using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Management.Products
{
   public partial class ProductView : XtraForm, IProductView
   {
      public ProductView()
      {
         InitializeComponent();
      }

      #region IProductView
      public string ViewText
      {
         set { Text = value; }
      }

      public int? Id
      {
         get
         {
            if (txtId.Text.Length == 0)
               return null;

            return Convert.ToInt32(txtId.Text);
         }
         set
         {
            txtId.Text = value.HasValue ? value.Value.ToString() : string.Empty;
         }
      }

      public string ProductModelName
      {
         get { return txtName.Text; }
         set { txtName.Text = value; }
      }

      public decimal Price
      {
         get { return numPrice.Value; }
         set { numPrice.Value = value; }
      }

      public decimal Cost
      {
         get { return numCost.Value; }
         set { numCost.Value = value; }
      }

      public ProductTypeViewModel ProductType
      {
         get { return (ProductTypeViewModel)cboProductType.SelectedItem; }
         set { cboProductType.SelectedValue = value.Id; }
      }

      public bool IsProductActive
      {
         get { return chkIsActive.Checked; }
         set { chkIsActive.Checked = value; }
      }

      public DateTime CreatedAt
      {
         set { txtCreatedAt.Text = value.ToLongDateString(); }
      }

      public DateTime UpdatedAt
      {
         set { txtUpdatedAt.Text = value.ToLongDateString(); }
      }

      public IEnumerable<ProductTypeViewModel> ProductTypes
      {
         get { return (IEnumerable<ProductTypeViewModel>)cboProductType.DataSource; }
         set
         {
            cboProductType.DataSource = value;
            cboProductType.DisplayMember = "Name";
            cboProductType.ValueMember = "Id";
            cboProductType.Refresh();
         }
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

      public event Action SaveProduct;
      #endregion

      private void ProductView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SaveProduct();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }

      private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtName.Text))
         {
            errorProvider.SetError(txtName, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtName, string.Empty);
      }

      private void cboProductType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (cboProductType.SelectedIndex == -1)
         {
            errorProvider.SetError(cboProductType, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(cboProductType, string.Empty);
      }
      #endregion
   }
}