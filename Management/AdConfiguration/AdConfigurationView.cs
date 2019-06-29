using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Management.AdConfiguration
{
   public partial class AdConfigurationView : XtraForm, IAdConfigurationView
   {
      public AdConfigurationView()
      {
         InitializeComponent();
      }

      #region IAdConfigurationView
      public string AdText
      {
         get { return txtText.Rtf.Replace("'", "$$"); }
         set { txtText.Rtf = value?.Replace("$$", "'"); }
      }

      public string Image1Path
      {
         get { return pbImage1.ImageLocation; }
         set
         {
            pbImage1.ImageLocation = value;

            if (!string.IsNullOrEmpty(value))
               pbImage1.Load(value);
         }
      }

      public byte Image1SizeMode
      {
         get { return (byte)pbImage1.SizeMode; }
         set { pbImage1.SizeMode = (PictureBoxSizeMode)value; }
      }

      public string Image2Path
      {
         get { return pbImage2.ImageLocation; }
         set
         {
            pbImage2.ImageLocation = value;

            if (!string.IsNullOrEmpty(value))
               pbImage2.Load(value);
         }
      }

      public byte Image2SizeMode
      {
         get { return (byte)pbImage2.SizeMode; }
         set { pbImage2.SizeMode = (PictureBoxSizeMode)value; }
      }

      public string Image3Path
      {
         get { return pbImage3.ImageLocation; }
         set
         {
            pbImage3.ImageLocation = value;

            if (!string.IsNullOrEmpty(value))
               pbImage3.Load(value);
         }
      }

      public byte Image3SizeMode
      {
         get { return (byte)pbImage3.SizeMode; }
         set { pbImage3.SizeMode = (PictureBoxSizeMode)value; }
      }

      public DateTime StartDate
      {
         get { return dtpStart.Value; }
         set { dtpStart.Value = value; }
      }

      public DateTime EndDate
      {
         get { return dtpEnd.Value; }
         set { dtpEnd.Value = value; }
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

      public event Action SaveAd;
      #endregion

      private void CheckinView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
         txtText.Focus();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         SaveAd();
      }

      private void cmsFont_Click(object sender, EventArgs e)
      {
         if (fontDialog.ShowDialog() == DialogResult.OK) { txtText.SelectionFont = fontDialog.Font; }
      }

      private void cmsColor_Click(object sender, EventArgs e)
      {
         if (colorDialog.ShowDialog() == DialogResult.OK) { txtText.SelectionColor = colorDialog.Color; }
      }

      private void cmsCopy_Click(object sender, EventArgs e)
      {
         Clipboard.SetText(txtText.Text);
      }

      private void cmsPaste_Click(object sender, EventArgs e)
      {
         var insertText = Clipboard.GetText();
         var selectionIndex = txtText.SelectionStart;
         txtText.Text = txtText.Text.Insert(selectionIndex, insertText);
         txtText.SelectionStart = selectionIndex + insertText.Length;
      }

      private void xtraTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
      {
         linkRedimImage.Visible = xtraTabControl.SelectedTabPageIndex > 0;
         linkRemoveImage.Visible = xtraTabControl.SelectedTabPageIndex > 0;
      }

      private void linkRemoveImage_Click(object sender, EventArgs e)
      {
         if (xtraTabControl.SelectedTabPageIndex == 1)
         {
            pbImage1.Image = null;
            Image1Path = null;
         }
         else if (xtraTabControl.SelectedTabPageIndex == 2)
         {
            pbImage2.Image = null;
            Image2Path = null;
         }
         else if (xtraTabControl.SelectedTabPageIndex == 3)
         {
            pbImage3.Image = null;
            Image3Path = null;
         }
      }

      private void linkRedimImage_Click(object sender, EventArgs e)
      {
         if (xtraTabControl.SelectedTabPageIndex == 1)
         {
            if (pbImage1.SizeMode == PictureBoxSizeMode.CenterImage)
               pbImage1.SizeMode = PictureBoxSizeMode.Normal;
            else if (pbImage1.SizeMode == PictureBoxSizeMode.Normal)
               pbImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            else if (pbImage1.SizeMode == PictureBoxSizeMode.StretchImage)
               pbImage1.SizeMode = PictureBoxSizeMode.Zoom;
            else if (pbImage1.SizeMode == PictureBoxSizeMode.Zoom)
               pbImage1.SizeMode = PictureBoxSizeMode.CenterImage;
         }
         else if (xtraTabControl.SelectedTabPageIndex == 2)
         {
            if (pbImage2.SizeMode == PictureBoxSizeMode.CenterImage)
               pbImage2.SizeMode = PictureBoxSizeMode.Normal;
            else if (pbImage2.SizeMode == PictureBoxSizeMode.Normal)
               pbImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            else if (pbImage2.SizeMode == PictureBoxSizeMode.StretchImage)
               pbImage2.SizeMode = PictureBoxSizeMode.Zoom;
            else if (pbImage2.SizeMode == PictureBoxSizeMode.Zoom)
               pbImage2.SizeMode = PictureBoxSizeMode.CenterImage;
         }
         else if (xtraTabControl.SelectedTabPageIndex == 3)
         {
            if (pbImage3.SizeMode == PictureBoxSizeMode.CenterImage)
               pbImage3.SizeMode = PictureBoxSizeMode.Normal;
            else if (pbImage3.SizeMode == PictureBoxSizeMode.Normal)
               pbImage3.SizeMode = PictureBoxSizeMode.StretchImage;
            else if (pbImage3.SizeMode == PictureBoxSizeMode.StretchImage)
               pbImage3.SizeMode = PictureBoxSizeMode.Zoom;
            else if (pbImage3.SizeMode == PictureBoxSizeMode.Zoom)
               pbImage3.SizeMode = PictureBoxSizeMode.CenterImage;
         }
      }

      private void pbImage1_Click(object sender, EventArgs e)
      {
         if (ofdProfilePicture.ShowDialog() == DialogResult.OK)
            Image1Path = ofdProfilePicture.FileName;
      }

      private void pbImage2_Click(object sender, EventArgs e)
      {
         if (ofdProfilePicture.ShowDialog() == DialogResult.OK)
            Image2Path = ofdProfilePicture.FileName;
      }

      private void pbImage3_Click(object sender, EventArgs e)
      {
         if (ofdProfilePicture.ShowDialog() == DialogResult.OK)
            Image3Path = ofdProfilePicture.FileName;
      }
   }
}