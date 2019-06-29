using System;
using Corlib;
using Corlib.Views.ViewModels;

namespace AccessControl.ZMessageBox
{
   public static class ZMessageBox
   {
      public static void Show(string message, MessageType type)
      {
         using (var form = new ZMessageBoxForm(message, type))
         {
            form.ShowDialog();
         }
      }

      internal static void Show(MessageViewModel message)
      {
         using (var form = new ZMessageBoxForm(message))
         {
            form.ShowDialog();
         }
      }
   }
}
