using Corlib;
using Corlib.Config;
using Corlib.Extensions;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Management.Extensions;
using Management.Properties;

namespace Management.Members
{
   public partial class MemberView : RibbonForm, IMemberView
   {
      public MemberView()
      {
         InitializeComponent();
      }

      #region IMemberView
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

      public IEnumerable<CityViewModel> Cities
      {
         get { return (IEnumerable<CityViewModel>)cboCity.DataSource; }
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

      public string Occupation
      {
         get { return txtOccupation.Text.Length == 0 ? null : txtOccupation.Text; }
         set { txtOccupation.Text = value; }
      }

      public string Organization
      {
         get { return txtOrganization.Text.Length == 0 ? null : txtOrganization.Text; }
         set { txtOrganization.Text = value; }
      }

      public string Conditions
      {
         get { return txtConditions.Text.Length == 0 ? null : txtConditions.Text; }
         set { txtConditions.Text = value; }
      }

      public string Medicine
      {
         get { return txtMedicine.Text.Length == 0 ? null : txtMedicine.Text; }
         set { txtMedicine.Text = value; }
      }

      public bool Smoke
      {
         get { return chkSmoke.Checked; }
         set { chkSmoke.Checked = value; }
      }

      public bool Alcohol
      {
         get { return chkAlcohol.Checked; }
         set { chkAlcohol.Checked = value; }
      }

      public bool Diet
      {
         get { return chkDiet.Checked; }
         set { chkDiet.Checked = value; }
      }

      public bool IsFirstTimeAtGym
      {
         get { return chkIsFirstTimeAtGym.Checked; }
         set { chkIsFirstTimeAtGym.Checked = value; }
      }

      public bool IsWorking
      {
         get { return chkIsWorking.Checked; }
         set { chkIsWorking.Checked = value; }
      }

      public bool IsStudying
      {
         get { return chkIsStudying.Checked; }
         set { chkIsStudying.Checked = value; }
      }

      public string OtherSports
      {
         get { return txtOtherSports.Text.Length == 0 ? null : txtOtherSports.Text; }
         set { txtOtherSports.Text = value; }
      }

      public string Lead
      {
         get { return txtLead.Text.Length == 0 ? null : txtLead.Text; }
         set { txtLead.Text = value; }
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

      public IEnumerable<MembershipViewModel> Memberships
      {
         get { return (IEnumerable<MembershipViewModel>)gridControlMemberships.DataSource; }
         set
         {
            gridControlMemberships.DataSource = value;
            gridViewMemberships_FocusedRowChanged(null, null);
         }
      }

      public IEnumerable<ContactViewModel> Contacts
      {
         get { return (IEnumerable<ContactViewModel>)gridControlContacts.DataSource; }
         set { gridControlContacts.DataSource = value; }
      }

      public IEnumerable<PaymentViewModel> Payments
      {
         get { return (IEnumerable<PaymentViewModel>)gridControlPayments.DataSource; }
         set { gridControlPayments.DataSource = value; }
      }

      public IEnumerable<NoteViewModel> Notes
      {
         get { return (IEnumerable<NoteViewModel>)gridControlNotes.DataSource; }
         set { gridControlNotes.DataSource = value; }
      }

      public IEnumerable<MemberFinancialMovementViewModel> FinancialMovements
      {
         get { return (IEnumerable<MemberFinancialMovementViewModel>)gridControlFinancialOverview.DataSource; }
         set { gridControlFinancialOverview.DataSource = value; }
      }

      public string FinancialBalanceSign { get; set; }

      public IEnumerable<PersonalTrainingRecordViewModel> PersonalTrainingRecords
      {
         get { return (IEnumerable<PersonalTrainingRecordViewModel>)gridControlPersonalTrainingRecords.DataSource; }
         set { gridControlPersonalTrainingRecords.DataSource = value; }
      }

      public string LastCheckin
      {
         set { txtLastCheckin.Text = value; }
      }

      public int TotalCheckins
      {
         set { txtTotalCheckins.Text = value.ToString(); }
      }

      public void InitializeView()
      {
         this.ClearControls();
         PulishGrids();
         AllowNavigation(false);
         tabControl.TabPages.First().PageEnabled = true;
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

      public bool Confirm(string message)
      {
         return XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
      }

      public void ShowView()
      {
         ShowDialog();
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

      public event EventHandler<EventArgs<AfterSaveAction>> SaveMember;
      public event Action DeleteMember;
      public event Action<EventArgs<ContactViewModel>> ShowContact;
      public event Action<int> DeleteContact;
      public event Action<EventArgs<NoteViewModel>> ShowNote;
      public event Action<int> DeleteNote;
      public event Action MoreCities;
      public event Action ProfilePictureClicked;
      public event Action<EventArgs<MembershipViewModel>> ShowMembership;
      public event Action<EventArgs<MembershipViewModel>> RenewMembership;
      public event Action<EventArgs<MembershipViewModel>> DeactivateMembership;
      public event Action<int> DeleteMembership;
      public event Action NewPayment;
      public event Action<int> DeletePayment;
      public event Action NewCheckin;
      public event Action PrintMemberInfo;
      public event Action PrintFinancialMovementsReport;
      public event Action<int> PrintReceipt;
      public event Action<EventArgs<PersonalTrainingRecordViewModel>> ShowPersonalTrainingRecord;
      public event Action<int> DeletePersonalTrainingRecord;
      public event Action PrintPersonalTrainingRecordsReport;
      public event Func<bool> CheckDuplicatedDNI;
      public event Action ShowBMICalculator;
      #endregion

      private void MemberView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
         Ribbon.Manager.UseF10KeyForMenu = false;

         if (Id.HasValue)
            AllowNavigation(true);
      }

      private void MemberView_FormClosing(object sender, FormClosingEventArgs e)
      {
         AutoValidate = AutoValidate.Disable;
         e.Cancel = false;
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
         {
            SaveMember(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.Nothing));
            AllowNavigation(true);
         }
      }

      private void btnSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
         {
            SaveMember(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.Close));
            AllowNavigation(true);
         }
      }

      private void btnSaveAndNew_ItemClick(object sender, ItemClickEventArgs e)
      {
         if (IsFormValid())
         {
            SaveMember(sender, new EventArgs<AfterSaveAction>(AfterSaveAction.New));
            AllowNavigation(true);
         }
      }

      private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
      {
         DeleteMember();
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
         if (FormValidator.HasValidationErrors(tabControl.Controls))
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
            errorProvider.SetError(txtDNI, "Ya existe un miembro con este DNI");
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

      #region Helpers
      private void AllowNavigation(bool value)
      {
         foreach (XtraTabPage tabPage in tabControl.TabPages)
            tabPage.PageEnabled = value;

         barButtonCheckin.Enabled = value;
         barButtonPrint.Enabled = value;
      }

      private void PulishGrids()
      {
         gridColumnContactName.Width = 300;
         gridColumnContactPhoneNumber1.Width = 192;
         gridColumnContactPhoneNumber2.Width = 192;
         gridColumnContactIsDoctor.Width = 45;
      }
      #endregion

      private void MemberView_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.F9)
            btnSave_ItemClick(null, null);
         else if (e.KeyCode == Keys.F10)
            btnSaveAndClose_ItemClick(null, null);
         else if (e.KeyCode == Keys.F12)
            btnClose_ItemClick(null, null);
      }

      private void linkNewContact_Click(object sender, EventArgs e)
      {
         ShowContact(new EventArgs<ContactViewModel>(null));
      }

      private void gridViewContacts_DoubleClick(object sender, EventArgs e)
      {
         var selectedContact = GetSelectedContact();

         if (selectedContact != null)
            ShowContact(new EventArgs<ContactViewModel>(selectedContact));
      }

      private void linkDeleteContact_Click(object sender, EventArgs e)
      {
         var selectedContact = GetSelectedContact();

         if (selectedContact != null)
            DeleteContact(selectedContact.Id);
      }

      private void linkMoreCities_Click(object sender, EventArgs e)
      {
         MoreCities();
      }

      private ContactViewModel GetSelectedContact()
      {
         if (gridControlContacts.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlContacts.MainView).GetSelectedRows().First();
         return (ContactViewModel)(((GridView)gridControlContacts.MainView).GetRow(selectedRow));
      }

      private NoteViewModel GetSelectedNote()
      {
         if (gridControlNotes.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlNotes.MainView).GetSelectedRows().First();
         return (NoteViewModel)(((GridView)gridControlNotes.MainView).GetRow(selectedRow));
      }

      private MembershipViewModel GetSelectedMembership()
      {
         if (gridControlMemberships.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlMemberships.MainView).GetSelectedRows().First();
         return (MembershipViewModel)(((GridView)gridControlMemberships.MainView).GetRow(selectedRow));
      }

      private PaymentViewModel GetSelectedPayment()
      {
         if (gridControlPayments.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlPayments.MainView).GetSelectedRows().First();
         return (PaymentViewModel)(((GridView)gridControlPayments.MainView).GetRow(selectedRow));
      }

      private PersonalTrainingRecordViewModel GetSelectedPersonalTrainingRecord()
      {
         if (gridControlPersonalTrainingRecords.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlPersonalTrainingRecords.MainView).GetSelectedRows().First();
         return (PersonalTrainingRecordViewModel)(((GridView)gridControlPersonalTrainingRecords.MainView).GetRow(selectedRow));
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

      private void btnNewNote_Click(object sender, EventArgs e)
      {
         ShowNote(new EventArgs<NoteViewModel>(null));
      }

      private void btnDeleteNote_Click(object sender, EventArgs e)
      {
         var selectedNote = GetSelectedNote();

         if (selectedNote != null)
            DeleteNote(selectedNote.Id);
      }

      private void gridViewNotes_DoubleClick(object sender, EventArgs e)
      {
         var selectedNote = GetSelectedNote();

         if (selectedNote != null)
            ShowNote(new EventArgs<NoteViewModel>(selectedNote));
      }

      private void gridViewMemberships_DoubleClick(object sender, EventArgs e)
      {
         var selectedMembership = GetSelectedMembership();
         ShowMembership(new EventArgs<MembershipViewModel>(selectedMembership));
      }

      private void gridViewMemberships_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
      {
         var membership = GetSelectedMembership();

         btnDeactivateMembership.Enabled = membership != null && membership.StatusCode == MembershipStatus.ACTIVE;
         btnRenewMembership.Enabled = membership != null && membership.StatusCode == MembershipStatus.EXPIRED;
      }

      private void btnNewMembership_Click(object sender, EventArgs e)
      {
         ShowMembership(new EventArgs<MembershipViewModel>(null));
      }

      private void btnRenewMembership_Click(object sender, EventArgs e)
      {
         var membership = GetSelectedMembership();

         if (membership != null)
            RenewMembership(new EventArgs<MembershipViewModel>(membership));
      }

      private void btnDeactivateMembership_Click(object sender, EventArgs e)
      {
         var membership = GetSelectedMembership();

         if (membership != null)
            DeactivateMembership(new EventArgs<MembershipViewModel>(membership));
      }

      private void btnDeleteMembership_Click(object sender, EventArgs e)
      {
         var membership = GetSelectedMembership();

         if (membership != null)
            DeleteMembership(membership.Id);
      }

      private void btnNewPaymentMembership_Click(object sender, EventArgs e)
      {
         NewPayment();
      }

      private void btnNewPaymentFinance_Click(object sender, EventArgs e)
      {
         NewPayment();
      }

      private void btnDeletePaymentFinanace_Click(object sender, EventArgs e)
      {
         var payment = GetSelectedPayment();

         if (payment != null)
            DeletePayment(payment.Id);
      }

      private void gridViewFinancialOverview_RowCellStyle(object sender, RowCellStyleEventArgs e)
      {
         var view = sender as GridView;
         if (view == null) return;

         if (e.RowHandle == 0)
            e.Appearance.ForeColor = "+".Equals(FinancialBalanceSign) ? Color.DarkGreen : Color.Red;
      }

      private void barButtonCheckin_ItemClick(object sender, ItemClickEventArgs e)
      {
         NewCheckin();
      }

      private void barButtonPrintMemberInfo_ItemClick(object sender, ItemClickEventArgs e)
      {
         PrintMemberInfo();
      }

      private void barButtonPrintMemberFinancialMovements_ItemClick(object sender, ItemClickEventArgs e)
      {
         PrintFinancialMovementsReport();
      }

      private void barButtonPrintMemberPersonalTrainingRecords_ItemClick(object sender, ItemClickEventArgs e)
      {
         PrintPersonalTrainingRecordsReport();
      }

      private void btnPrintReceipt_Click(object sender, EventArgs e)
      {
         var selectedPayment = GetSelectedPayment();

         if (selectedPayment != null)
            PrintReceipt(selectedPayment.Id);
      }

      private void btnNewPersonalTrainingRecord_Click(object sender, EventArgs e)
      {
         ShowPersonalTrainingRecord(new EventArgs<PersonalTrainingRecordViewModel>(null));
      }

      private void btnDeletePersonalTrainingRecord_Click(object sender, EventArgs e)
      {
         var selectedPersonalTrainingRecord = GetSelectedPersonalTrainingRecord();

         if (selectedPersonalTrainingRecord != null)
            DeletePersonalTrainingRecord(selectedPersonalTrainingRecord.Id);
      }

      private void gridViewPersonalTrainingRecords_DoubleClick(object sender, EventArgs e)
      {
         var selectedPersonalTrainingRecord = GetSelectedPersonalTrainingRecord();

         if (selectedPersonalTrainingRecord != null)
            ShowPersonalTrainingRecord(new EventArgs<PersonalTrainingRecordViewModel>(selectedPersonalTrainingRecord));
      }

      private void btnBMI_Click(object sender, EventArgs e)
      {
         ShowBMICalculator();
      }
   }
}
