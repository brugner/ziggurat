using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Management.ShiftsAndQuotas
{
   public partial class ShiftsAndQuotasView : XtraForm, IShiftsAndQuotasView
   {
      public ShiftsAndQuotasView()
      {
         InitializeComponent();
      }

      #region IShiftsAndQuotasView
      public IEnumerable<ShiftViewModel> Shifts
      {
         get { return (IEnumerable<ShiftViewModel>)gridControlShifts.DataSource; }
         set { gridControlShifts.DataSource = value; }
      }

      public string TrainingName
      {
         set { txtTrainingName.Text = value; }
      }

      public string DaysNames
      {
         set { txtDaysNames.Text = value; }
      }

      public string ShiftTime
      {
         set { txtTime.Text = value; }
      }

      public string Quota
      {
         set { txtQuota.Text = value; }
      }

      public string AvailableQuota
      {
         set { txtAvailableQuota.Text = value; }
      }

      public IEnumerable<MemberViewModel> Members
      {
         get { return (IEnumerable<MemberViewModel>)gridControlMembers.DataSource; }
         set { gridControlMembers.DataSource = value; }
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
         Show();
      }

      public event Action<EventArgs<ShiftViewModel>> SelectedShiftChanged;
      #endregion

      private void ShiftsAndQuotasView_Load(object sender, System.EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void gridViewShifts_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
      {
         var view = sender as GridView;
         var info = e.Info as GridGroupRowInfo;
         var currentValue = view.GetGroupRowValue(e.RowHandle, info.Column).ToString();
         var newValue = currentValue.Remove(0, currentValue.IndexOf('-') + 1);
         info.GroupText = newValue;
      }

      private void gridViewShifts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
      {
         var selectedShift = GetSelectedShift();

         if (selectedShift != null)
            SelectedShiftChanged(new EventArgs<ShiftViewModel>(selectedShift));
      }

      #region Helpers
      private ShiftViewModel GetSelectedShift()
      {
         if (gridControlShifts.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlShifts.MainView).GetSelectedRows().First();
         var selectedCheckin = (ShiftViewModel)(((GridView)gridControlShifts.MainView).GetRow(selectedRow));
         return selectedCheckin;
      }
      #endregion
   }
}