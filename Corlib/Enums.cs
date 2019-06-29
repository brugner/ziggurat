using System;

namespace Corlib
{
	public enum MessageType
	{
		Information,
		Warning,
		Error
	}

	public enum AfterSaveAction
	{
		Nothing,
		Close,
		New
	}

	public struct MembershipStatus
	{
		public static readonly byte ACTIVE = 1;
		public static readonly byte EXPIRED = 2;
	}

	public struct MembershipLength
	{
		public static readonly byte CLASS = 0;
		public static readonly byte WEEK = 1;
		public static readonly byte MONTH = 2;
		public static readonly byte QUARTER = 3;
		public static readonly byte OTHER = 4;
	}

	[Flags]
	public enum QuickStatsOption
	{
		TotalMembers = 1,
		ActiveMembers = 2,
		MostPopularTraining = 4,
		DailyAverageCheckins = 8,
		MonthlyAverageCheckins = 16,
		MostSoldProduct = 32,
		CheckinsLast30Days = 64,
		SalesLast30Days = 128,
		PaymentsLast30Days = 256
	}

	public struct IsActive
	{
		public static readonly byte NO = 0;
		public static readonly byte YES = 1;
	}

	public enum Report
	{
		Members = 0,
		Checkins = 1,
		Sales = 2,
		Products = 3,
		RedOnes = 4,

		MemberInfo = 5,
		FinancialMovements = 6,
		Receipt = 7,
		PersonalTrainingRecords = 8,
	}

	public enum FinancialMovementType
	{
		Debit,
		Credit
	}

	public enum FinancialMovementReference
	{
		Membership,
		Sale,
		Payment
	}

	public enum Entity
	{
		Member,
		Trainer,
		Ad
	}

	public struct AppEnvironment
	{
		public bool IsProduction
		{
			get
			{
				var value = Environment.GetEnvironmentVariable("ZIGGURAT_ENVIRONMENT", EnvironmentVariableTarget.User);
				return string.IsNullOrEmpty(value) || "Production".Equals(value);
			}
		}
	}
}
