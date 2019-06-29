using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace Management.Statistics
{
	public partial class StatisticsView : XtraForm, IStatisticsView
	{
		public StatisticsView()
		{
			InitializeComponent();
		}

		#region IStatisticsView
		public int TotalMembers
		{
			set { lbTotalMembers.Text = value.ToString(); }
		}

		public decimal ActiveMembersPercentage
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

		public int CheckinsLast30Days
		{
			set { lbCheckinsLast30Days.Text = value.ToString(); }
		}

		public int SalesLast30Days
		{
			set { lbSalesLast30Days.Text = value.ToString(); }
		}

		public decimal PaymentsLast30Days
		{
			set { lbPaymentsLast30Days.Text = "$" + value.ToString(); }
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

		public DataTable MembersJoiningDateSeriesData
		{
			set
			{
				chartControlMembersJoiningDate.Series.Clear();
				chartControlMembersJoiningDate.DataSource = null;

				var membersJoiningDateSeries = new Series("MembersJoiningDate", ViewType.Line);
				chartControlMembersJoiningDate.Series.Add(membersJoiningDateSeries);
				membersJoiningDateSeries.DataSource = value;
				membersJoiningDateSeries.ArgumentScaleType = ScaleType.DateTime;
				membersJoiningDateSeries.ArgumentDataMember = "Argument";
				membersJoiningDateSeries.ValueScaleType = ScaleType.Numerical;
				membersJoiningDateSeries.ValueDataMembers.AddRange(new string[] { "Value" });
			}
		}

		public DataTable MembersByGenderSeriesData
		{
			set
			{
				chartControlMembersByGender.Series.Clear();
				chartControlMembersByGender.DataSource = null;

				var membersByGenderSeries = new Series("MembersByGender", ViewType.Bar);
				chartControlMembersByGender.Series.Add(membersByGenderSeries);
				membersByGenderSeries.DataSource = value;
				membersByGenderSeries.ArgumentScaleType = ScaleType.Qualitative;
				membersByGenderSeries.ArgumentDataMember = "Argument";
				membersByGenderSeries.ValueScaleType = ScaleType.Numerical;
				membersByGenderSeries.ValueDataMembers.AddRange(new string[] { "Value" });
			}
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

		public DataTable CheckinsByTrainingSeriesData
		{
			set
			{
				chartControlCheckinsByTraining.Series.Clear();
				chartControlCheckinsByTraining.DataSource = null;

				var checkinsByTrainingSeries = new Series("CheckinsByTraining", ViewType.Pie);
				chartControlCheckinsByTraining.Series.Add(checkinsByTrainingSeries);
				checkinsByTrainingSeries.DataSource = value;
				checkinsByTrainingSeries.ArgumentScaleType = ScaleType.Auto;
				checkinsByTrainingSeries.ArgumentDataMember = "Argument";
				checkinsByTrainingSeries.ValueScaleType = ScaleType.Numerical;
				checkinsByTrainingSeries.ValueDataMembers.AddRange(new string[] { "Value" });
				checkinsByTrainingSeries.Label.TextPattern = "{VP:0.00%}";
				checkinsByTrainingSeries.LegendTextPattern = "{A}: {V}";
			}
		}

		public DataTable SalesByCategorySeriesData
		{
			set
			{
				chartControlSalesByCategory.Series.Clear();
				chartControlSalesByCategory.DataSource = null;

				var salesByCategorySeries = new Series("SalesByCategory", ViewType.Pie3D);
				chartControlSalesByCategory.Series.Add(salesByCategorySeries);
				salesByCategorySeries.DataSource = value;
				salesByCategorySeries.ArgumentScaleType = ScaleType.Auto;
				salesByCategorySeries.ArgumentDataMember = "Argument";
				salesByCategorySeries.ValueScaleType = ScaleType.Numerical;
				salesByCategorySeries.ValueDataMembers.AddRange(new string[] { "Value" });
				salesByCategorySeries.Label.TextPattern = "{VP:0.00%}";
				salesByCategorySeries.LegendTextPattern = "{A}: {V}";
			}
		}

		public DataTable SalesAmountLast30DaysSeriesData
		{
			set
			{
				chartControlSalesAmountLast30Days.Series.Clear();
				chartControlSalesAmountLast30Days.DataSource = null;

				var salesAmountLast30DaysSeries = new Series("SalesAmountLast30Days", ViewType.Line);
				chartControlSalesAmountLast30Days.Series.Add(salesAmountLast30DaysSeries);
				salesAmountLast30DaysSeries.DataSource = value;
				salesAmountLast30DaysSeries.ArgumentScaleType = ScaleType.DateTime;
				salesAmountLast30DaysSeries.ArgumentDataMember = "Argument";
				salesAmountLast30DaysSeries.ValueScaleType = ScaleType.Numerical;
				salesAmountLast30DaysSeries.ValueDataMembers.AddRange(new string[] { "Value" });
			}
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
			Show();
		}
		#endregion

		private void StatisticsView_Load(object sender, EventArgs e)
		{
			defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
		}
	}
}
