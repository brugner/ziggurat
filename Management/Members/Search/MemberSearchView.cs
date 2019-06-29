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

namespace Management.Members.Search
{
   public partial class MemberSearchView : XtraForm, IMemberSearchView
   {
      public MemberSearchView()
      {
         InitializeComponent();
      }

      #region ISearchMemberView
      public IEnumerable<MemberViewModel> Members
      {
         get { return (IEnumerable<MemberViewModel>)gridControlMembers.DataSource; }
         set { gridControlMembers.DataSource = value; }
      }

      public MemberViewModel SelectedMember
      {
         get { return GetSelectedMember(); }
      }

      public void ShowView()
      {
         ShowDialog();
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

      public event Action MemberSelected;
      #endregion

      private void gridViewMembers_DoubleClick(object sender, System.EventArgs e)
      {
         MemberSelected();
      }

      private MemberViewModel GetSelectedMember()
      {
         if (gridControlMembers.MainView.RowCount == 0)
            return null;

         var selectedRow = ((GridView)gridControlMembers.MainView).GetSelectedRows().First();
         var selectedMember = (MemberViewModel)(((GridView)gridControlMembers.MainView).GetRow(selectedRow));
         return selectedMember;
      }
   }
}