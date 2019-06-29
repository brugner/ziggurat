using Corlib;
using Corlib.Config;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;

namespace AccessControl.ZMessageBox
{
   public partial class ZMessageBoxForm : XtraForm
   {
      public ZMessageBoxForm()
      {
         InitializeComponent();
      }

      public ZMessageBoxForm(string message, MessageType type) : this()
      {
         Text = AppConfig.AppName + " | " + AppConfig.Parameters.Gym.Name;

         lbMessage.Text = message;

         if (type == MessageType.Error)
            pbIcon.Image = Properties.Resources.errorMessageIcon256;

         pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
         pbIcon.Size = new Size(142, 145);
      }

      public ZMessageBoxForm(MessageViewModel message) : this()
      {
         Text = $"Tienes un nuevo mensaje! Enviado el {message.Date.ToString("dddd dd 'de' MMMM 'de' yyyy 'a las' hh:mm:ss")}";

         lbMessage.Text = message.Body;
         pbIcon.Hide();
         lbMessage.Location = new Point(17, 42);
         lbMessage.Size = new Size(621, 118);
         lbMessage.TextAlign = ContentAlignment.TopLeft;
			lbSubject.BringToFront();
			lbSubject.Visible = true;
         lbSubject.Text = "Asunto: " + message.Subject;
      }

      private void ZMessageBoxForm_KeyPress(object sender, KeyPressEventArgs e)
      {
         Close();
      }
   }
}