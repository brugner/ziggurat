using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Management.Payments
{
   public partial class NewPaymentView : XtraForm, INewPaymentView
   {
      private static Logger _logger = LogManager.GetCurrentClassLogger();

      public NewPaymentView()
      {
         InitializeComponent();
      }

      #region INewPaymentView
      public string ViewText
      {
         set { Text = value; }
      }

      public IEnumerable<DebtViewModel> Debts
      {
         get { return (IEnumerable<DebtViewModel>)gridControlDebts.DataSource; }
         set { gridControlDebts.DataSource = value; }
      }

      public DebtViewModel CheckedDebt
      {
         get
         {
            var debts = (IEnumerable<DebtViewModel>)gridControlDebts.DataSource;
            return debts.Where(x => x.IsSelected).FirstOrDefault();
         }
         set
         {
            var debts = new List<DebtViewModel>();
            debts.Add(value);
            gridControlDebts.DataSource = debts;
         }
      }

      public decimal Amount
      {
         get { return numAmount.Value; }
         set { numAmount.Value = value; }
      }

      public DateTime Date
      {
         get { return dtpDate.Value; }
         set { dtpDate.Value = value; }
      }

      public string Comment
      {
         get { return txtComment.Text; }
         set { txtComment.Text = value; }
      }

      public void CloseView()
      {
         Close();
      }

      public void InitializeView()
      {
         cboPaymentMethod.SelectedIndex = 0;
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

      public event Action SavePayment;
      #endregion

      private void NewPaymentView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
         gridViewDebts.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      }

      private void repositoryItemCheckEditSelected_CheckedChanged(object sender, EventArgs e)
      {
         try
         {
            var selectedRow = ((GridView)gridControlDebts.MainView).GetSelectedRows().First();
            var selectedDebt = (DebtViewModel)(((GridView)gridControlDebts.MainView).GetRow(selectedRow));

            var debts = (IEnumerable<DebtViewModel>)gridControlDebts.DataSource;
            gridControlDebts.DataSource = null;

            foreach (var item in debts)
               item.IsSelected = false;

            debts.Where(x => x.Description.Equals(selectedDebt.Description)).FirstOrDefault().IsSelected = true;
            gridControlDebts.DataSource = debts;

            numAmount.Value = selectedDebt.DebtAmount;
         }
         catch (Exception ex)
         {
            gridControlDebts.DataSource = null;
            _logger.Error(ex);
            Notify("Ha ocurrido un error, por favor intenta nuevamente", MessageType.Error);
         }
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SavePayment();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }

      private void numAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         var debts = (IEnumerable<DebtViewModel>)gridControlDebts.DataSource;
         var selectedDebt = debts.Where(x => x.IsSelected).FirstOrDefault();

         if (numAmount.Value > selectedDebt.Amount)
         {
            errorProvider.SetError(numAmount, "El importe a pagar no puede ser mayor que el adeudado");
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(numAmount, string.Empty);
      }
      #endregion
   }
}