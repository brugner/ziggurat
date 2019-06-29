using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Management.Extensions
{
   public static class ControlExtensions
   {
      public static void ClearControls(this Control form)
      {
         foreach (Control control in form.Controls)
         {
            if (control is TextBox)
               control.ResetText();

            if (control is CheckBox)
               ((CheckBox)control).Checked = false;

            if (control is CheckedListBoxControl)
               ((CheckedListBoxControl)control).UnCheckAll();

            if (control is ListBoxControl)
               ((ListBoxControl)control).DataSource = null;

            if (control?.Controls.Count > 0)
               control.ClearControls();
         }
      }
   }
}
