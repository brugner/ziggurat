using Corlib.Config;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AccessControl.Help
{
   public partial class AccessControlHelpView : XtraForm
   {
      public AccessControlHelpView()
      {
         InitializeComponent();
      }

      private void AccessControlHelpView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void AccessControlHelpView_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == '/')
            Close();
      }
   }
}
