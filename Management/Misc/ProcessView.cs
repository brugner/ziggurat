using System.Windows.Forms;

namespace Management.Misc
{
   public partial class ProcessView : Form
   {
      public string Message
      {
         get { return lbMessage.Text; }
         set { lbMessage.Text = value; }
      }

      public ProcessView()
      {
         InitializeComponent();
      }
   }
}
