using Corlib.Config;
using DevExpress.XtraEditors;
using System;

namespace Management.Sales
{
   public partial class AskForQuantityView : XtraForm
   {
      public AskForQuantityView()
      {
         InitializeComponent();
      }

      public byte? Quantity { get; internal set; }

      private void AskForValueView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
         numQuantity.Focus();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         Quantity = (byte)numQuantity.Value;
      }
   }
}