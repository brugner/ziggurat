using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Management.Extensions;

namespace Management.Trainings
{
   public partial class TrainingView : RibbonForm, ITrainingView
   {
      #region ITrainingView
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

      public string TrainingName
      {
         get { return txtName.Text; }
         set { txtName.Text = value; }
      }

      public decimal ClassPrice
      {
         get { return numClassPrice.Value; }
         set { numClassPrice.Value = value; }
      }

      public decimal WeekPrice
      {
         get { return numWeekPrice.Value; }
         set { numWeekPrice.Value = value; }
      }

      public decimal MonthPrice
      {
         get { return numMonthPrice.Value; }
         set { numMonthPrice.Value = value; }
      }

      public decimal QuarterPrice
      {
         get { return numQuarterPrice.Value; }
         set { numQuarterPrice.Value = value; }
      }

      public IList<TrainerViewModel> Trainers
      {
         get { return (IList<TrainerViewModel>)clbTrainers.DataSource; }
         set
         {
            clbTrainers.DataSource = value;
            clbTrainers.ValueMember = "Id";
            clbTrainers.DisplayMember = "FullName";
         }
      }

      public IList<TrainerViewModel> SelectedTrainers
      {
         get
         {
            var selectedTrainers = new List<TrainerViewModel>();

            foreach (var item in clbTrainers.CheckedItems)
            {
               var trainer = (TrainerViewModel)item;
               selectedTrainers.Add(trainer);
            }

            return selectedTrainers;
         }
         set
         {
            foreach (var trainer in value)
            {
               int index = clbTrainers.FindString(trainer.FullName);

               if (index > -1)
                  clbTrainers.SetItemChecked(index, true);
            }
         }
      }

      public IList<ShiftViewModel> Shifts
      {
         get { return (IList<ShiftViewModel>)lbcShifts.DataSource; }
         set
         {
            lbcShifts.DataSource = value;
            lbcShifts.ValueMember = "Number";
            lbcShifts.DisplayMember = "DisplayName";
         }
      }

      public DateTime CreatedAt
      {
         set { txtCreatedAt.Text = value.ToLongDateString() + " a las " + value.ToLongTimeString(); }
      }

      public DateTime UpdatedAt
      {
         set { txtUpdatedAt.Text = value.ToLongDateString() + " a las " + value.ToLongTimeString(); }
      }

      public void InitializeView()
      {
         this.ClearControls();
         numClassPrice.Value = 1;
         numClassPrice.Value = 0.00M;
         numWeekPrice.Value = 1;
         numWeekPrice.Value = 0.00M;
         numMonthPrice.Value = 1;
         numMonthPrice.Value = 0.00M;
         numQuarterPrice.Value = 1;
         numQuarterPrice.Value = 0.00M;

         txtName.Select();
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

      public void ShowView()
      {
         ShowDialog();
      }

      public bool Confirm(string message)
      {
         return XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
      }

      public event EventHandler<EventArgs<AfterSaveAction>> SaveTraining;
      public event Action DeleteTraining;
      public event Action<EventArgs<ShiftViewModel>> ShowShift;
      public event Action<EventArgs<ShiftViewModel>> RemoveShift;
      public event Func<bool> ClosingView;
      #endregion

      public TrainingView()
      {
         InitializeComponent();
      }

      private void TrainingView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
         Ribbon.Manager.UseF10KeyForMenu = false;
      }

      private void TrainingView_FormClosing(object sender, FormClosingEventArgs e)
      {
         e.Cancel = !ClosingView();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
            SaveTraining(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.Nothing));
      }

      private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
            SaveTraining(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.Close));
      }

      private void btnSaveAndNew_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
            SaveTraining(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.New));
      }

      private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
      {
         DeleteTraining();
      }

      private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
      {
         Close();
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
         if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
         {
            errorProvider.SetError(txtName, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtName, string.Empty);
      }

      private void clbTrainers_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (clbTrainers.CheckedItemsCount == 0)
         {
            errorProvider.SetError(clbTrainers, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(clbTrainers, string.Empty);
      }
      #endregion

      private void TrainingView_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.F9)
            btnSave_ItemClick(null, null);
         else if (e.KeyCode == Keys.F10)
            btnSaveAndClose_ItemClick(null, null);
         else if (e.KeyCode == Keys.F12)
            btnClose_ItemClick(null, null);
      }

      private void clbTrainers_DataSourceChanged(object sender, EventArgs e)
      {
         gbTrainers.Text = $"Entrenadores ({clbTrainers.CheckedItemsCount})";
      }

      private void clbTrainers_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
      {
         gbTrainers.Text = $"Entrenadores ({clbTrainers.CheckedItemsCount})";
      }

      private void linkNewShift_Click(object sender, EventArgs e)
      {
         ShowShift(new EventArgs<ShiftViewModel>(null));
      }

      private void linkRemoveShift_Click(object sender, EventArgs e)
      {
         var selectedShift = GetSelectedShift();

         if (selectedShift != null)
            RemoveShift(new EventArgs<ShiftViewModel>(selectedShift));
      }

      private void lbcShifts_DoubleClick(object sender, EventArgs e)
      {
         var selectedShift = GetSelectedShift();

         if (selectedShift != null)
            ShowShift(new EventArgs<ShiftViewModel>(selectedShift));
      }

      #region Helpers
      private ShiftViewModel GetSelectedShift()
      {
         var shifts = (List<ShiftViewModel>)lbcShifts.DataSource;

         if (shifts.Count == 0)
            return null;

         return shifts[lbcShifts.SelectedIndex];
      }
      #endregion
   }
}
