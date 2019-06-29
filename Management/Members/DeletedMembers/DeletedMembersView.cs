using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Management.Members.DeletedMembers
{
   public partial class DeletedMembersView : XtraForm, IDeletedMembersView
   {
      public DeletedMembersView()
      {
         InitializeComponent();
      }

      #region IDeletedMembersView
      public IEnumerable<MemberViewModel> Members
      {
         get { return (IEnumerable<MemberViewModel>)gridControlRecords.DataSource; }
         set { gridControlRecords.DataSource = value; }
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

      public event Action<int> RestoreMember;
      #endregion

      private void DeletedMembersView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void gridViewMembers_DoubleClick(object sender, EventArgs e)
      {
         var selectedMember = GetSelectedMember();

         if (selectedMember != null)
            RestoreMember(selectedMember.Id);
      }

      #region Helpers
      private MemberViewModel GetSelectedMember()
      {
         if (gridControlRecords.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlRecords.MainView).GetSelectedRows().First();
         var selectedMember = (MemberViewModel)(((GridView)gridControlRecords.MainView).GetRow(selectedRow));
         return selectedMember;
      }
      #endregion
   }
}