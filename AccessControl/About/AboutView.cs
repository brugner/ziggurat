using DevExpress.XtraEditors;
using System;
using System.Reflection;

namespace AccessControl.About
{
   public partial class AboutView : XtraForm
   {
      public AboutView()
      {
         InitializeComponent();
      }

      private void AboutView_Load(object sender, EventArgs e)
      {
         lbVersion.Text = "Versión: " + Assembly.GetEntryAssembly().GetName().Version.ToString();
         lbCopyright.Text = $"Brugnner © {DateTime.Today.Year}";
      }

      private void AboutView_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
      {
         if (e.KeyChar == '/')
            Close();
      }
   }
}