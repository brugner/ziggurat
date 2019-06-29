using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraNavBar;
using Management.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Management.Main
{
	public partial class MainView : RibbonForm, IMainView
	{
		private bool CloseItAnyway = false;

		public MainView()
		{
			InitializeComponent();
		}

		#region IMainView
		public string ViewText
		{
			set { Text = value; }
		}

		public string Username
		{
			set { bsiUsername.Caption = value; }
		}

		public IEnumerable<MemberViewModel> Members
		{
			get { return (IEnumerable<MemberViewModel>)gridControlMembers.DataSource; }
			set
			{
				gridControlMembers.DataSource = value;
				SelectedMemberChanged(null, new EventArgs<MemberViewModel>(GetSelectedMember()));
			}
		}

		public string SelectedMemberFullName
		{
			set { lbSelectedMemberFullName.Text = value; }
		}

		public string SelectedMemberDNI
		{
			set { lbSelectedMemberDNI.Text = value; }
		}

		public string SelectedMemberAddress
		{
			set { lbSelectedMemberAddress.Text = value; }
		}

		public string SelectedMemberMobilePhone
		{
			set { lbSelectedMemberMobilePhone.Text = value; }
		}

		public string SelectedMemberProfilePicturePath
		{
			set
			{
				if (!string.IsNullOrEmpty(value))
					pbSelectedMemberProfilePicture.Load(value);
				else
					pbSelectedMemberProfilePicture.Image = Resources.default_profile;
			}
		}

		public byte SelectedMemberProfilePictureSizeMode
		{
			set { pbSelectedMemberProfilePicture.SizeMode = (PictureBoxSizeMode)value; }
		}

		public IEnumerable<MembershipViewModel> SelectedMemberActiveMemberships
		{
			set { gridControlSelectedMemberActiveMemberships.DataSource = value; }
		}

		public string SelectedMemberLastCheckin
		{
			set { lbSelectedMemberLastCheckin.Text = value; }
		}

		public int SelectedMemberTotalCheckins
		{
			set { lbSelectedMemberTotalCheckins.Text = value.ToString(); }
		}

		public IEnumerable<TrainerViewModel> Trainers
		{
			get { return (IEnumerable<TrainerViewModel>)gridControlTrainers.DataSource; }
			set
			{
				foreach (var trainer in value)
					if (File.Exists(trainer.ProfilePicturePath))
						trainer.ProfilePicture = new Bitmap(trainer.ProfilePicturePath);
					else
						trainer.ProfilePicture = Resources.default_profile;

				gridControlTrainers.DataSource = value;
			}
		}

		public IEnumerable<TrainingViewModel> Trainings
		{
			get { return (IEnumerable<TrainingViewModel>)gridControlTrainings.DataSource; }
			set { gridControlTrainings.DataSource = value; }
		}

		public IEnumerable<CheckinViewModel> Checkins
		{
			get { return (IEnumerable<CheckinViewModel>)gridControlCheckins.DataSource; }
			set
			{
				foreach (var checkin in value)
					if (File.Exists(checkin.ProfilePicturePath))
						checkin.ProfilePicture = new Bitmap(checkin.ProfilePicturePath);
					else
						checkin.ProfilePicture = Resources.default_profile;

				gridControlCheckins.DataSource = value;
			}
		}

		public IEnumerable<ProductViewModel> Products
		{
			get { return (IEnumerable<ProductViewModel>)gridControlProducts.DataSource; }
			set { gridControlProducts.DataSource = value; }
		}

		public IEnumerable<SaleViewModel> Sales
		{
			get { return (IEnumerable<SaleViewModel>)gridControlSales.DataSource; }
			set { gridControlSales.DataSource = value; }
		}

		public DataTable CheckinsSeriesData
		{
			set
			{
				chartControlCheckins.Series.Clear();
				chartControlCheckins.DataSource = null;

				var checkinsSeries = new Series("Checkins", ViewType.Line);
				chartControlCheckins.Series.Add(checkinsSeries);
				checkinsSeries.DataSource = value;
				checkinsSeries.ArgumentScaleType = ScaleType.DateTime;
				checkinsSeries.ArgumentDataMember = "Argument";
				checkinsSeries.ValueScaleType = ScaleType.Numerical;
				checkinsSeries.ValueDataMembers.AddRange(new string[] { "Value" });
			}
		}

		public DataTable MembershipsSeriesData
		{
			set
			{
				chartControlMemberships.Series.Clear();
				chartControlMemberships.DataSource = null;

				var membershipsSeries = new Series("Memberships", ViewType.Pie);
				chartControlMemberships.Series.Add(membershipsSeries);
				membershipsSeries.DataSource = value;
				membershipsSeries.ArgumentScaleType = ScaleType.Auto;
				membershipsSeries.ArgumentDataMember = "Argument";
				membershipsSeries.ValueScaleType = ScaleType.Numerical;
				membershipsSeries.ValueDataMembers.AddRange(new string[] { "Value" });
				membershipsSeries.Label.TextPattern = "{VP:P0}";
				membershipsSeries.LegendTextPattern = "{A}: {V}";
			}
		}

		public int TotalMembers
		{
			set { lbTotalMembers.Text = value.ToString(); }
		}

		public decimal ActiveMembers
		{
			set { lbActiveMembers.Text = value.ToString() + "%"; }
		}

		public decimal DailyAverageCheckins
		{
			set { lbDailyAverageCheckins.Text = value.ToString(); }
		}

		public decimal MonthlyAverageCheckins
		{
			set { lbMonthlyAverageCheckins.Text = value.ToString(); }
		}

		public string MostPopularTraining
		{
			set { lbMostPopularTraining.Text = value; }
		}

		public string MostSoldProduct
		{
			set { lbMostSoldProduct.Text = value; }
		}

		public IEnumerable<BirthdayViewModel> WeekBirthdays
		{
			set { gridControlBirthdays.DataSource = value; }
		}

		public string StatusBarMessage
		{
			set
			{
				lbStatusBarMessage.Caption = value;
				Application.DoEvents();
			}
		}

		public void ShowView()
		{
			Show();
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

		public event EventHandler<EventArgs<MemberViewModel>> SelectedMemberChanged;
		public event Action<EventArgs<MemberViewModel>> ShowMember;
		public event Action<EventArgs<MemberViewModel>> DeleteMember;
		public event Action<EventArgs<ProductViewModel>> ShowProduct;
		public event Action<EventArgs<ProductViewModel>> DeleteProduct;
		public event Action<EventArgs<TrainerViewModel>> ShowTrainer;
		public event Action<EventArgs<TrainerViewModel>> DeleteTrainer;
		public event Action<EventArgs<TrainingViewModel>> ShowTraining;
		public event Action<EventArgs<TrainingViewModel>> DeleteTraining;
		public event Action<EventArgs<MemberViewModel>> NewCheckin;
		public event Action<int> DeleteCheckin;
		public event Action RefreshDashboardData;
		public event Action RefreshMembers;
		public event Action RefreshCheckins;
		public event Action ShowMessages;
		public event Action ShowAdConfiguration;
		public event Action<EventArgs<MemberViewModel>> NewMessageToMember;
		public event Action ShowParameters;
		public event Func<bool> ViewClosing;
		public event Action ShowProductTypes;
		public event Action NewSale;
		public event Action ShowShiftsAndQuotas;
		public event Action ShowReports;
		public event Action PrintProductsReport;
		public event Action<int> PrintMemberInfoReport;
		public event Action PrintMembersReport;
		public event Action ShowDeletedMembers;
		public event Action ShowDatabaseBackupRecords;
		public event Action ShowIMCCalculator;
		public event Action ViewLoaded;
		public event Action ShowHelp;
		public event Action ShowUserProfile;
		public event Action ShowStatistics;
		#endregion

		private void MainView_Load(object sender, EventArgs e)
		{
			defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;

			splitContainerMembersVertical.SplitterPosition = AppConfig.Parameters.SplitContainerMembersVerticalSplitterPosition;
			splitContainerMembersHorizontal.SplitterPosition = AppConfig.Parameters.SplitContainerMembersHorizontalSplitterPosition;
			Ribbon.Manager.UseF10KeyForMenu = false;
			lbCopyleft.Caption = $"Brugnner © {DateTime.Today.Year}";

			lbVersionBackstageViewAbout.Text = GetVersion();
			lbCopyrightBackstageViewAbout.Text = $"Brugnner © {DateTime.Today.Year}";
			ViewLoaded();
		}

		private void MainView_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!CloseItAnyway)
				e.Cancel = !ViewClosing();
		}

		private void MainView_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		void navBarControl_ActiveGroupChanged(object sender, NavBarGroupEventArgs e)
		{
			switch (e.Group.Name)
			{
				case "dashboardNavBarGroup":
					ribbonPageDashboard.Visible = true;
					ribbonPageMembers.Visible = false;
					ribbonPageCheckIn.Visible = false;
					ribbonPagePointOfSale.Visible = false;
					ribbonPageTrainers.Visible = false;
					ribbonPageTrainings.Visible = false;
					ribbonControl.SelectedPage = ribbonPageDashboard;
					RefreshDashboardData();
					break;

				case "membersNavBarGroup":
					ribbonPageDashboard.Visible = false;
					ribbonPageMembers.Visible = true;
					ribbonPageCheckIn.Visible = false;
					ribbonPagePointOfSale.Visible = false;
					ribbonPageTrainers.Visible = false;
					ribbonPageTrainings.Visible = false;
					ribbonControl.SelectedPage = ribbonPageMembers;
					break;

				case "checkInNavBarGroup":
					ribbonPageDashboard.Visible = false;
					ribbonPageMembers.Visible = false;
					ribbonPageCheckIn.Visible = true;
					ribbonPagePointOfSale.Visible = false;
					ribbonPageTrainers.Visible = false;
					ribbonPageTrainings.Visible = false;
					ribbonControl.SelectedPage = ribbonPageCheckIn;
					RefreshCheckins();
					break;

				case "pointOfSaleNavBarGroup":
					ribbonPageDashboard.Visible = false;
					ribbonPageMembers.Visible = false;
					ribbonPageCheckIn.Visible = false;
					ribbonPagePointOfSale.Visible = true;
					ribbonPageTrainers.Visible = false;
					ribbonPageTrainings.Visible = false;
					ribbonControl.SelectedPage = ribbonPagePointOfSale;
					break;

				case "trainersNavBarGroup":
					ribbonPageDashboard.Visible = false;
					ribbonPageMembers.Visible = false;
					ribbonPageCheckIn.Visible = false;
					ribbonPagePointOfSale.Visible = false;
					ribbonPageTrainers.Visible = true;
					ribbonPageTrainings.Visible = false;
					ribbonControl.SelectedPage = ribbonPageTrainers;
					break;

				case "trainingsNavBarGroup":
					ribbonPageDashboard.Visible = false;
					ribbonPageMembers.Visible = false;
					ribbonPageCheckIn.Visible = false;
					ribbonPagePointOfSale.Visible = false;
					ribbonPageTrainers.Visible = false;
					ribbonPageTrainings.Visible = true;
					ribbonControl.SelectedPage = ribbonPageTrainings;
					break;
			}

			navBarControl.ActiveGroup = e.Group;
			navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
		}

		private void backstageViewButtonHelp_ItemClick(object sender, BackstageViewItemEventArgs e)
		{
			ShowHelp();
		}

		private void backstageViewButtonExit_ItemClick(object sender, BackstageViewItemEventArgs e)
		{
			if (ViewClosing())
			{
				CloseItAnyway = true;
				Application.Exit();
			}
		}

		private void barButtonMembers_ItemClick(object sender, ItemClickEventArgs e)
		{
			navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(membersNavBarGroup));
		}

		private void barButtonCheckins_ItemClick(object sender, ItemClickEventArgs e)
		{
			navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(checkInNavBarGroup));
		}

		private void barButtonPointOfSale_ItemClick(object sender, ItemClickEventArgs e)
		{
			navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(pointOfSaleNavBarGroup));
		}

		private void barButtonTrainers_ItemClick(object sender, ItemClickEventArgs e)
		{
			navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(trainersNavBarGroup));
		}

		private void barButtonTrainings_ItemClick(object sender, ItemClickEventArgs e)
		{
			navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(trainingsNavBarGroup));
		}

		private void gridViewMembers_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			SelectedMemberChanged(sender, new EventArgs<MemberViewModel>(GetSelectedMember()));
		}

		private void gridViewMembers_DoubleClick(object sender, EventArgs e)
		{
			EditMember();
		}

		private void btnEditMember_ItemClick(object sender, ItemClickEventArgs e)
		{
			EditMember();
		}

		private void btnNewMember_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowMember(new EventArgs<MemberViewModel>(null));
		}

		private void linkEditMember_Click(object sender, EventArgs e)
		{
			EditMember();
		}

		private void EditMember()
		{
			var selectedMember = GetSelectedMember();

			if (selectedMember != null)
				ShowMember(new EventArgs<MemberViewModel>(selectedMember));
		}

		private MemberViewModel GetSelectedMember()
		{
			if (gridControlMembers.MainView.RowCount == 0)
				return null;

			var selectedRow = ((GridView)gridControlMembers.MainView).GetSelectedRows().First();
			var selectedMember = (MemberViewModel)(((GridView)gridControlMembers.MainView).GetRow(selectedRow));
			return selectedMember;
		}

		private void MainView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
				navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(dashboardNavBarGroup));
			else if (e.KeyCode == Keys.F2)
				navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(membersNavBarGroup));
			else if (e.KeyCode == Keys.F3)
				navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(checkInNavBarGroup));
			else if (e.KeyCode == Keys.F4)
				navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(pointOfSaleNavBarGroup));
			else if (e.KeyCode == Keys.F5)
				navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(trainersNavBarGroup));
			else if (e.KeyCode == Keys.F6)
				navBarControl_ActiveGroupChanged(sender, new NavBarGroupEventArgs(trainingsNavBarGroup));
		}

		private void btnEditTrainer_ItemClick(object sender, ItemClickEventArgs e)
		{
			EditTrainer();
		}

		private void EditTrainer()
		{
			var selectedTrainer = GetSelectedTrainer();

			if (selectedTrainer != null)
				ShowTrainer(new EventArgs<TrainerViewModel>(selectedTrainer));
		}

		private TrainerViewModel GetSelectedTrainer()
		{
			if (gridControlTrainers.MainView.RowCount == 0)
				return null;

			var selectedRow = ((LayoutView)gridControlTrainers.MainView).GetSelectedRows().First();
			var selectedTrainer = (TrainerViewModel)(((LayoutView)gridControlTrainers.MainView).GetRow(selectedRow));
			return selectedTrainer;
		}

		private void btnNewTrainer_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowTrainer(new EventArgs<TrainerViewModel>(null));
		}

		private void btnDeleteTrainer_ItemClick(object sender, ItemClickEventArgs e)
		{
			var trainer = GetSelectedTrainer();

			if (trainer != null)
				DeleteTrainer(new EventArgs<TrainerViewModel>(trainer));
		}

		private void layoutViewTrainers_DoubleClick(object sender, EventArgs e)
		{
			EditTrainer();
		}

		private void btnDeleteMember_ItemClick(object sender, ItemClickEventArgs e)
		{
			var member = GetSelectedMember();

			if (member != null)
				DeleteMember(new EventArgs<MemberViewModel>(member));
		}

		private void btnParameters_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowParameters();
		}

		private void btnNewTraining_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowTraining(new EventArgs<TrainingViewModel>(null));
		}

		private void btnEditTraining_ItemClick(object sender, ItemClickEventArgs e)
		{
			EditTraining();
		}

		private void btnDeleteTraining_ItemClick(object sender, ItemClickEventArgs e)
		{
			var training = GetSelectedTraining();

			if (training != null)
				DeleteTraining(new EventArgs<TrainingViewModel>(training));
		}

		private void EditTraining()
		{
			var selectedTraining = GetSelectedTraining();

			if (selectedTraining != null)
				ShowTraining(new EventArgs<TrainingViewModel>(selectedTraining));
		}

		private TrainingViewModel GetSelectedTraining()
		{
			if (gridControlTrainings.MainView.RowCount == 0)
				return null;

			var selectedRow = ((LayoutView)gridControlTrainings.MainView).GetSelectedRows().First();
			var selectedTraining = (TrainingViewModel)(((LayoutView)gridControlTrainings.MainView).GetRow(selectedRow));
			return selectedTraining;
		}

		private void layoutViewTrainings_DoubleClick(object sender, EventArgs e)
		{
			EditTraining();
		}

		private void splitContainerMembersVertical_SplitterPositionChanged(object sender, EventArgs e)
		{
			AppConfig.Parameters.SplitContainerMembersVerticalSplitterPosition = splitContainerMembersVertical.SplitterPosition;
		}

		private void splitContainerMembersHorizontal_SplitterPositionChanged(object sender, EventArgs e)
		{
			AppConfig.Parameters.SplitContainerMembersHorizontalSplitterPosition = splitContainerMembersHorizontal.SplitterPosition;
		}

		private void barButtonMessages_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowMessages();
		}

		private void barButtonAdConfiguration_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowAdConfiguration();
		}

		#region Checkins
		private void barButtonNewCheckin_ItemClick(object sender, ItemClickEventArgs e)
		{
			NewCheckin(new EventArgs<MemberViewModel>(null));
		}

		private void barButtonDeleteCheckin_ItemClick(object sender, ItemClickEventArgs e)
		{
			var checkin = GetSelectedCheckin();

			if (checkin != null)
				DeleteCheckin(checkin.Id);
		}
		#endregion

		private CheckinViewModel GetSelectedCheckin()
		{
			if (gridControlCheckins.MainView.RowCount == 0)
				return null;

			var selectedRow = ((LayoutView)gridControlCheckins.MainView).GetSelectedRows().First();
			var selectedCheckin = (CheckinViewModel)(((LayoutView)gridControlCheckins.MainView).GetRow(selectedRow));
			return selectedCheckin;
		}

		private void barButtonRefreshCheckins_ItemClick(object sender, ItemClickEventArgs e)
		{
			RefreshCheckins();
		}

		private void barButtonRefreshDashboardData_ItemClick(object sender, ItemClickEventArgs e)
		{
			RefreshDashboardData();
		}

		private void linkDeleteMember_Click(object sender, EventArgs e)
		{
			var member = GetSelectedMember();

			if (member != null)
				DeleteMember(new EventArgs<MemberViewModel>(member));
		}

		private void linkSendMessage_Click(object sender, EventArgs e)
		{
			var member = GetSelectedMember();

			if (member != null)
				NewMessageToMember(new EventArgs<MemberViewModel>(member));
		}

		private void barButtonNewCheckinMember_ItemClick(object sender, ItemClickEventArgs e)
		{
			var member = GetSelectedMember();
			NewCheckin(new EventArgs<MemberViewModel>(member));
		}

		private void barButtonRefreshMembers_ItemClick(object sender, ItemClickEventArgs e)
		{
			RefreshMembers();
		}

		private void gridViewBirthdays_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
		{
			var view = sender as GridView;
			var info = e.Info as GridGroupRowInfo;
			var currentValue = view.GetGroupRowValue(e.RowHandle, info.Column).ToString();
			var newValue = currentValue.Remove(0, currentValue.IndexOf('/') - 2);
			info.GroupText = newValue;
		}

		private void barButtonNewProduct_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowProduct(new EventArgs<ProductViewModel>(null));
		}

		private void barButtonEditProduct_ItemClick(object sender, ItemClickEventArgs e)
		{
			EditProduct();
		}

		private void barButtonDeleteProduct_ItemClick(object sender, ItemClickEventArgs e)
		{
			var product = GetSelectedProduct();

			if (product != null)
				DeleteProduct(new EventArgs<ProductViewModel>(product));
		}

		private void barButtonProductTypes_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowProductTypes();
		}

		private ProductViewModel GetSelectedProduct()
		{
			if (gridControlProducts.MainView.RowCount == 0)
				return null;

			var selectedRow = ((GridView)gridControlProducts.MainView).GetSelectedRows().First();
			var selectedProduct = (ProductViewModel)(((GridView)gridControlProducts.MainView).GetRow(selectedRow));
			return selectedProduct;
		}

		private void EditProduct()
		{
			var selectedProduct = GetSelectedProduct();

			if (selectedProduct != null)
				ShowProduct(new EventArgs<ProductViewModel>(selectedProduct));
		}

		private void gridViewProducts_DoubleClick(object sender, EventArgs e)
		{
			EditProduct();
		}

		private void barButtonNewSale_ItemClick(object sender, ItemClickEventArgs e)
		{
			NewSale();
		}

		private void barButtonShiftsAndQuotas_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowShiftsAndQuotas();
		}

		private void barButtonReports_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowReports();
		}

		private void linkPrintMemberInfo_Click(object sender, EventArgs e)
		{
			var selectedMember = GetSelectedMember();

			if (selectedMember != null)
				PrintMemberInfoReport(selectedMember.Id);
		}

		private void barButtonPrintMembersReport_ItemClick(object sender, ItemClickEventArgs e)
		{
			PrintMembersReport();
		}

		private void barButtonPrintCheckinsReport_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowReports();
		}

		private void barButtonDeletedMembers_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowDeletedMembers();
		}

		#region Helpers
		private string GetVersion()
		{
			return "Versión: " + Assembly.GetEntryAssembly().GetName().Version.ToString();
		}
		#endregion

		private void barButtonPointOfSalePrintProducts_ItemClick(object sender, ItemClickEventArgs e)
		{
			PrintProductsReport();
		}

		private void barButtonPointOfSalePrintSales_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowReports();
		}

		private void backstageViewButtonParameters_ItemClick(object sender, BackstageViewItemEventArgs e)
		{
			ShowParameters();
		}

		private void barButtonDatabaseBackups_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowDatabaseBackupRecords();
		}

		private void barButtonIMCCalculator_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowIMCCalculator();
		}

		private void barButtonHelp_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowHelp();
		}

		private void bsiUsername_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowUserProfile();
		}

		private void barButtonStats_ItemClick(object sender, ItemClickEventArgs e)
		{
			ShowStatistics();
		}
	}
}
//TODO: ayuda
