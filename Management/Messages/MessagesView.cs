using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Management.Messages
{
   public partial class MessagesView : RibbonForm, IMessagesView
   {
      public MessagesView()
      {
         InitializeComponent();
      }

      #region IMessagesView
      public IEnumerable<MessageViewModel> Messages
      {
         get { return (IEnumerable<MessageViewModel>)gridControlMessages.DataSource; }
         set { gridControlMessages.DataSource = value; }
      }

      public void CloseView()
      {
         Close();
      }

      public void InitializeView()
      {
         Text = AppConfig.Parameters.Gym.Name + " | Mensajes";
         PulishGrid();
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
         Show();
      }

      public event EventHandler<EventArgs<MessageViewModel>> ShowMessage;
      #endregion

      private void MessagesView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;

         Ribbon.Manager.UseF10KeyForMenu = false;
         lbCopyright.Caption = $"Brugnner © {DateTime.Today.Year}";
      }

      private void PulishGrid()
      {
         gridColumnMessageRecipientsNames.Width = 360;
         gridColumnMessageBody.Width = 840;
         gridColumnMessageDateTime.Width = 130;
      }

      private void barButtonNewMessage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         ShowMessage(sender, new EventArgs<MessageViewModel>(null));
      }

      private void gridViewMessages_DoubleClick(object sender, EventArgs e)
      {
         var selectedMessage = GetSelectedMessage();

         if (selectedMessage != null)
            ShowMessage(null, new EventArgs<MessageViewModel>(selectedMessage));
      }

      private MessageViewModel GetSelectedMessage()
      {
         if (gridControlMessages.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlMessages.MainView).GetSelectedRows().First();
         var selectedMessage = (MessageViewModel)(((GridView)gridControlMessages.MainView).GetRow(selectedRow));
         return selectedMessage;
      }
   }
}