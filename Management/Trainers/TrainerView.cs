using Corlib;
using Corlib.Config;
using Corlib.Extensions;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Management.Cities;
using Management.Extensions;
using Management.Properties;

namespace Management.Trainers
{
   public partial class TrainerView : RibbonForm, ITrainerView
   {
      #region ITrainerView
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

      public int DNI
      {
         get { return Convert.ToInt32(txtDNI.Text); }
         set { txtDNI.Text = value.ToString(); }
      }

      public string FirstName
      {
         get { return txtFirstName.Text; }
         set { txtFirstName.Text = value; }
      }

      public string LastName
      {
         get { return txtLastName.Text; }
         set { txtLastName.Text = value; }
      }

      public DateTime DateOfBirth
      {
         get { return dtpDOB.Value; }
         set { dtpDOB.Value = value; }
      }

      public string Gender
      {
         get { return radioGroupGender.SelectedIndex == 0 ? "F" : "M"; }
         set { radioGroupGender.SelectedIndex = value == "F" ? 0 : 1; }
      }

      public string Address
      {
         get { return txtAddress.Text.Length == 0 ? null : txtAddress.Text; }
         set { txtAddress.Text = value; }
      }

      public IList<CityViewModel> Cities
      {
         get { return (List<CityViewModel>)cboCity.DataSource; }
         set
         {
            cboCity.DataSource = value;
            cboCity.DisplayMember = "Name";
            cboCity.ValueMember = "Id";
            cboCity.Refresh();
         }
      }

      public CityViewModel City
      {
         get { return (CityViewModel)cboCity.SelectedItem; }
         set { cboCity.SelectedValue = value.Id; }
      }

      public int? MobilePhoneAreaCode
      {
         get
         {
            if (string.IsNullOrEmpty(txtMobilePhoneAreaCode.Text))
               return null;

            return int.Parse(txtMobilePhoneAreaCode.Text);
         }
         set { txtMobilePhoneAreaCode.Text = value.ToString(); }
      }

      public long? MobilePhoneNumber
      {
         get
         {
            if (string.IsNullOrEmpty(txtMobilePhoneNumber.Text))
               return null;

            return long.Parse(txtMobilePhoneNumber.Text);
         }
         set { txtMobilePhoneNumber.Text = value.ToString(); }
      }

      public string HomePhone
      {
         get { return txtHomePhone.Text; }
         set { txtHomePhone.Text = value; }
      }

      public string Email
      {
         get { return txtEmail.Text.Length == 0 ? null : txtEmail.Text; }
         set { txtEmail.Text = value; }
      }

      public DateTime JoiningDate
      {
         set { txtJoiningDate.Text = value.ToLongDateString(); }
      }

      public DateTime UpdatedAt
      {
         set { txtUpdatedAt.Text = value.ToLongDateString(); }
      }

      public string ProfilePicturePath
      {
         get { return pbProfilePicture.ImageLocation; }
         set
         {
            pbProfilePicture.ImageLocation = value;

            if (!string.IsNullOrEmpty(value))
               pbProfilePicture.Load(value);
            else
               pbProfilePicture.Image = Resources.default_profile;
         }
      }

      public byte ProfilePictureSizeMode
      {
         get { return (byte)pbProfilePicture.SizeMode; }
         set { pbProfilePicture.SizeMode = (PictureBoxSizeMode)value; }
      }

      public void InitializeView()
      {
         this.ClearControls();
         txtDNI.Select();
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

      public ICitiesView CreateCitiesView()
      {
         return new CitiesView();
      }

      public bool Confirm(string message)
      {
         return XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
      }

      public void AddCity(CityViewModel selectedCity)
      {
         if (selectedCity == null)
            return;

         var cities = (List<CityViewModel>)cboCity.DataSource;
         cities.Add(selectedCity);

         cboCity.DataSource = null;
         Cities = cities;
         City = selectedCity;
      }

      public void ShowChangeProfilePictureDialog()
      {
         if (ofdProfilePicture.ShowDialog() == DialogResult.OK)
            ProfilePicturePath = ofdProfilePicture.FileName;
      }

      public event EventHandler<EventArgs<AfterSaveAction>> SaveTrainer;
      public event Action DeleteTrainer;
      public event Action MoreCities;
      public event Action ProfilePictureClicked;
      public event Func<bool> CheckDuplicatedDNI;
      #endregion

      public TrainerView()
      {
         InitializeComponent();
      }

      private void TrainerView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
         Ribbon.Manager.UseF10KeyForMenu = false;
      }

      private void TrainerView_FormClosing(object sender, FormClosingEventArgs e)
      {
         AutoValidate = AutoValidate.Disable;
         e.Cancel = false;
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
            SaveTrainer(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.Nothing));
      }

      private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
            SaveTrainer(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.Close));
      }

      private void btnSaveAndNew_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
            SaveTrainer(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.New));
      }

      private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
      {
         DeleteTrainer();
      }

      private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
      {
         Close();
      }

      private void lbAge_Click(object sender, EventArgs e)
      {
         lbAge.ToolTip = dtpDOB.Value.ToAgeString();
      }

      private void lbAge_MouseHover(object sender, EventArgs e)
      {
         lbAge.ToolTip = dtpDOB.Value.ToAgeString();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }

      private void txtDNI_Validating(object sender, CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtDNI.Text.Trim()))
         {
            errorProvider.SetError(txtDNI, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtDNI, string.Empty);

         if (txtDNI.Text.Trim().Length < 7)
         {
            errorProvider.SetError(txtDNI, "Debe tener 7 u 8 dígitos");
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtDNI, string.Empty);

         if (CheckDuplicatedDNI())
         {
            errorProvider.SetError(txtDNI, "Ya existe un entrenador con este DNI");
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtDNI, string.Empty);
      }

      private void txtFirstName_Validating(object sender, CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtFirstName.Text.Trim()))
         {
            errorProvider.SetError(txtFirstName, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtFirstName, string.Empty);
      }

      private void txtLastName_Validating(object sender, CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtLastName.Text.Trim()))
         {
            errorProvider.SetError(txtLastName, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtLastName, string.Empty);
      }

      private void txtMobilePhoneAreaCode_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
      }

      private void txtMobilePhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;
      }

      private void txtMobilePhoneNumber_Validating(object sender, CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtMobilePhoneNumber.Text.Trim()) && string.IsNullOrWhiteSpace(txtHomePhone.Text.Trim()))
         {
            errorProvider.SetError(txtMobilePhoneNumber, AppConfig.Parameters.ValidationMessages.EnterAtLeastAPhone);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtMobilePhoneNumber, string.Empty);

         if (!string.IsNullOrWhiteSpace(txtMobilePhoneNumber.Text.Trim()) && string.IsNullOrWhiteSpace(txtMobilePhoneAreaCode.Text.Trim()))
         {
            errorProvider.SetError(txtMobilePhoneNumber, AppConfig.Parameters.ValidationMessages.EnterMobilePhoneAreaCode);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtMobilePhoneNumber, string.Empty);

         if (string.IsNullOrWhiteSpace(txtMobilePhoneNumber.Text.Trim()) && !string.IsNullOrWhiteSpace(txtMobilePhoneAreaCode.Text.Trim()))
         {
            errorProvider.SetError(txtMobilePhoneNumber, AppConfig.Parameters.ValidationMessages.EnterPhoneNumber);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtMobilePhoneNumber, string.Empty);
      }

      private void txtHomePhone_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\- \/]"))
            e.Handled = true;
      }

      private void txtHomePhone_Validating(object sender, CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtMobilePhoneNumber.Text.Trim()) && string.IsNullOrWhiteSpace(txtHomePhone.Text.Trim()))
         {
            errorProvider.SetError(txtMobilePhoneNumber, AppConfig.Parameters.ValidationMessages.EnterAtLeastAPhone);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtHomePhone, string.Empty);
      }

      private void txtEmail_Validating(object sender, CancelEventArgs e)
      {
         string regex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

         if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !Regex.IsMatch(txtEmail.Text.Trim(), regex))
         {
            errorProvider.SetError(txtEmail, AppConfig.Parameters.ValidationMessages.InvalidEmailAddress);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtEmail, string.Empty);
      }
      #endregion

      private void TrainerView_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.F9)
            btnSave_ItemClick(null, null);
         else if (e.KeyCode == Keys.F10)
            btnSaveAndClose_ItemClick(null, null);
         else if (e.KeyCode == Keys.F12)
            btnClose_ItemClick(null, null);
      }

      private void linkMoreCities_Click(object sender, EventArgs e)
      {
         MoreCities();
      }

      private void pbProfilePicture_Click(object sender, EventArgs e)
      {
         ProfilePictureClicked();
      }

      private void linkRemoveProfilePicture_Click(object sender, EventArgs e)
      {
         pbProfilePicture.Image = null;
         ProfilePicturePath = null;
      }

      private void linkRedimProfilePicture_Click(object sender, EventArgs e)
      {
         if (pbProfilePicture.SizeMode == PictureBoxSizeMode.CenterImage)
            pbProfilePicture.SizeMode = PictureBoxSizeMode.Normal;
         else if (pbProfilePicture.SizeMode == PictureBoxSizeMode.Normal)
            pbProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
         else if (pbProfilePicture.SizeMode == PictureBoxSizeMode.StretchImage)
            pbProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
         else if (pbProfilePicture.SizeMode == PictureBoxSizeMode.Zoom)
            pbProfilePicture.SizeMode = PictureBoxSizeMode.CenterImage;
      }
   }
}
