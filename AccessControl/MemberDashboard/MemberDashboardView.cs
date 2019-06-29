using AccessControl.Help;
using AccessControl.Properties;
using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AccessControl.MemberDashboard
{
   public partial class MemberDashboardView : XtraForm, IMemberDashboardView
   {
      private byte _activeAdImage = 2;
      private Random _random = new Random();

      public MemberDashboardView()
      {
         InitializeComponent();
      }

      #region IMemberDashboardView
      public string Title
      {
         set { lbTitle.Text = value; }
      }

      public string MemberProfilePicturePath
      {
         set
         {
            pbProfilePicture.ImageLocation = value;

            if (!string.IsNullOrEmpty(value) && File.Exists(value))
               pbProfilePicture.Load(value);
            else
               pbProfilePicture.Image = Resources.default_profile;
         }
      }

      public byte MemberProfilePictureSizeMode
      {
         set { pbProfilePicture.SizeMode = (PictureBoxSizeMode)value; }
      }

      public string MemberName
      {
         set { lbMemberName.Text = value; }
      }

      public IEnumerable<ActiveMembershipViewModel> ActiveMemberships
      {
         get { return (IEnumerable<ActiveMembershipViewModel>)gridControlMemberships.DataSource; }
         set { gridControlMemberships.DataSource = value; }
      }

      public byte SelectedMembershipLineNumber
      {
         get
         {
            byte.TryParse(txtMembershipNumber.Text, out byte value);
            return value;
         }
      }

      public string AdText
      {
         set { txtAdText.Rtf = value?.Replace("$$", "'"); }
      }

      private string _imagePath1;
      public string Image1Path
      {
         get { return _imagePath1; }
         set
         {
            _imagePath1 = value;
            pbAdImage.ImageLocation = value;

            if (!string.IsNullOrEmpty(value))
               pbAdImage.Load(value);
         }
      }

      private byte _image1SizeMode;
      public byte Image1SizeMode
      {
         get { return _image1SizeMode; }
         set
         {
            _image1SizeMode = value;
            pbAdImage.SizeMode = (PictureBoxSizeMode)value;
         }
      }

      public string Image2Path { get; set; }
      public byte Image2SizeMode { get; set; }
      public string Image3Path { get; set; }
      public byte Image3SizeMode { get; set; }

      public DataTable CheckinsSeriesData
      {
         set
         {
            chartControlCheckins.Series.Clear();
            chartControlCheckins.DataSource = null;

            var checkinsSeries = new Series("Checkins", ViewType.Line);
            chartControlCheckins.Series.Add(checkinsSeries);
            checkinsSeries.DataSource = value;
            checkinsSeries.ArgumentScaleType = ScaleType.DateTime;
            checkinsSeries.ArgumentDataMember = "Argument";
            checkinsSeries.ValueScaleType = ScaleType.Numerical;
            checkinsSeries.ValueDataMembers.AddRange(new string[] { "Value" });
         }
      }

      public string JoiningDate
      {
         set { lbJoiningDate2.Text = value; }
      }

      public int TotalCheckinCount
      {
         set { lbTotalCheckinsCount2.Text = value.ToString(); }
      }

      public string LastCheckin
      {
         set { lbLastCheckin2.Text = value; }
      }

      public string FavoriteTraining
      {
         set { lbFavoriteTraining2.Text = value; }
      }

      public string FavoriteProduct
      {
         set { lbFavoriteProduct2.Text = value; }
      }

      public string BirthdayDaysCount
      {
         set { lbBirthdayDaysCount.Text = value; }
      }

      private bool _isTodayBirthday;
      public bool IsTodayBirthday
      {
         get { return _isTodayBirthday; }
         set
         {
            _isTodayBirthday = value;
            if (_isTodayBirthday)
            {
               lbBirthdayDaysCount.Font = new Font("Tahoma", 20, FontStyle.Bold);
               timerBirthday.Start();
            }
         }
      }

      public void ShowView()
      {
         Show();
      }

      public void HideView()
      {
         Hide();
      }

      public void CloseView()
      {
         Close();
      }

      public void Notify(string message, MessageType type)
      {
         ZMessageBox.ZMessageBox.Show(message, type);
      }

      public bool Confirm(string message)
      {
         return true;
      }

      public void ShowMessage(MessageViewModel message)
      {
         ZMessageBox.ZMessageBox.Show(message);
      }

      public event Action NewCheckin;
      #endregion

      private void MemberDashboardView_Load(object sender, EventArgs e)
      {
         var height = Screen.FromControl(this).Bounds.Height;
         var width = Screen.FromControl(this).Bounds.Width;

         ResizeControls(width, height);
      }

      private void MemberDashboardView_Resize(object sender, EventArgs e)
      {
         var height = Screen.FromControl(this).Bounds.Height;
         var width = Screen.FromControl(this).Bounds.Width;

         ResizeControls(width, height);
      }

      private void MemberDashboardView_FormClosed(object sender, FormClosedEventArgs e)
      {
         if (AppConfig.Environment.IsProduction)
            Application.Restart();
         else
            Application.Exit();
      }

      private void MemberDashboardView_KeyPress(object sender, KeyPressEventArgs e)
      {
         ProcessKey(e.KeyChar);
      }

      private void gridControlMemberships_KeyPress(object sender, KeyPressEventArgs e)
      {
         ProcessKey(e.KeyChar);
      }

      private void txtMembershipNumber_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;

         ProcessKey(e.KeyChar);
      }

      private void timerClock_Tick(object sender, EventArgs e)
      {
         lbClock.Text = $"{DateTime.Now.ToString("hh:mm:ss")}";
      }

      private void timerAd_Tick(object sender, EventArgs e)
      {
         string path = Image1Path;
         var sizeMode = PictureBoxSizeMode.Normal;

         switch (_activeAdImage)
         {
            case 1:
               path = Image1Path;
               sizeMode = (PictureBoxSizeMode)Image1SizeMode;
               _activeAdImage = 2;
               break;

            case 2:
               path = Image2Path;
               sizeMode = (PictureBoxSizeMode)Image2SizeMode;
               _activeAdImage = 3;
               break;

            case 3:
               path = Image3Path;
               sizeMode = (PictureBoxSizeMode)Image3SizeMode;
               _activeAdImage = 1;
               break;
         }

         if (File.Exists(path))
            pbAdImage.Load(path);

         pbAdImage.SizeMode = sizeMode;
      }

      private void timerBirthday_Tick(object sender, EventArgs e)
      {
         lbBirthdayDaysCount.ForeColor = GetRandomColor();
      }

      #region Helpers
      private void ProcessKey(char keyChar)
      {
         if (keyChar == '/')
            Close();

         if (keyChar == '-')
            Clear();

         if (keyChar == '*')
            ShowHelp();

         if (txtMembershipNumber.Text.Length > 0 && keyChar == (char)Keys.Enter)
            NewCheckin();
      }

      private void ShowHelp()
      {
         var view = new AccessControlHelpView();
         view.ShowDialog();
      }

      private void Clear()
      {
         txtMembershipNumber.Text = string.Empty;
         txtMembershipNumber.Focus();
      }

      private void ResizeControls(int width, int height)
      {
         if (width == 1920 && height == 1080)
         {
            lbTitle.Font = new Font("Tahoma", 27, FontStyle.Bold);
            lbMemberName.Font = new Font("Tahoma", 24, FontStyle.Bold);
            lbQuestion.Font = new Font("Tahoma", 18, FontStyle.Bold);
            lbTrainingNumber.Font = new Font("Tahoma", 18, FontStyle.Bold);
            lbNeedHelp.Font = new Font("Tahoma", 18, FontStyle.Italic);
            lbClock.Font = new Font("Tahoma", 18, FontStyle.Bold);
            lbCheckins.Font = new Font("Tahoma", 12, FontStyle.Regular);
            lbBirthdayDaysCount.Font = new Font("Tahoma", 12, FontStyle.Regular);

            txtMembershipNumber.Font = new Font("Tahoma", 20, FontStyle.Bold);

            gridControlMemberships.Size = new Size(588, 125);
            gridControlMemberships.Location = new Point(22, 354);

            gridColumnMembershipLineNumber.AppearanceHeader.Font = new Font("Tahoma", 15, FontStyle.Regular);
            gridColumnMembershipTrainingName.AppearanceHeader.Font = new Font("Tahoma", 15, FontStyle.Regular);
            gridColumnMembershipStartDate.AppearanceHeader.Font = new Font("Tahoma", 15, FontStyle.Regular);
            gridColumnMembershipEndDate.AppearanceHeader.Font = new Font("Tahoma", 15, FontStyle.Regular);

            gridColumnMembershipLineNumber.AppearanceCell.Font = new Font("Tahoma", 15, FontStyle.Regular);
            gridColumnMembershipTrainingName.AppearanceCell.Font = new Font("Tahoma", 15, FontStyle.Regular);
            gridColumnMembershipStartDate.AppearanceCell.Font = new Font("Tahoma", 15, FontStyle.Regular);
            gridColumnMembershipEndDate.AppearanceCell.Font = new Font("Tahoma", 15, FontStyle.Regular);

            pbAdImage.Location = new Point(74, 91);
            pbAdImage.Size = new Size(384, 293);
            txtAdText.Location = new Point(74, 390);
            txtAdText.Size = new Size(384, 287);
         }

         if (width == 1366 && height == 768)
         {
            lbTitle.Font = new Font("Tahoma", 23, FontStyle.Bold);
            lbMemberName.Font = new Font("Tahoma", 20, FontStyle.Bold);
            lbQuestion.Font = new Font("Tahoma", 14, FontStyle.Bold);
            lbTrainingNumber.Font = new Font("Tahoma", 14, FontStyle.Bold);
            lbNeedHelp.Font = new Font("Tahoma", 14, FontStyle.Italic);
            lbClock.Font = new Font("Tahoma", 14, FontStyle.Bold);
            lbCheckins.Font = new Font("Tahoma", 10, FontStyle.Regular);
            lbBirthdayDaysCount.Font = new Font("Tahoma", 10, FontStyle.Regular);

            txtMembershipNumber.Font = new Font("Tahoma", 16, FontStyle.Bold);

            gridControlMemberships.Size = new Size(550, 125);
            gridControlMemberships.Location = new Point(45, 354);

            gridColumnMembershipLineNumber.AppearanceHeader.Font = new Font("Tahoma", 11, FontStyle.Regular);
            gridColumnMembershipTrainingName.AppearanceHeader.Font = new Font("Tahoma", 11, FontStyle.Regular);
            gridColumnMembershipStartDate.AppearanceHeader.Font = new Font("Tahoma", 11, FontStyle.Regular);
            gridColumnMembershipEndDate.AppearanceHeader.Font = new Font("Tahoma", 11, FontStyle.Regular);

            gridColumnMembershipLineNumber.AppearanceCell.Font = new Font("Tahoma", 11, FontStyle.Regular);
            gridColumnMembershipTrainingName.AppearanceCell.Font = new Font("Tahoma", 11, FontStyle.Regular);
            gridColumnMembershipStartDate.AppearanceCell.Font = new Font("Tahoma", 11, FontStyle.Regular);
            gridColumnMembershipEndDate.AppearanceCell.Font = new Font("Tahoma", 11, FontStyle.Regular);

            pbAdImage.Location = new Point(16, 91);
            pbAdImage.Size = new Size(350, 259);
            txtAdText.Location = new Point(12, 390);
            txtAdText.Size = new Size(350, 253);
         }
      }

      private Color GetRandomColor()
      {
         return Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
      }
      #endregion
   }
}