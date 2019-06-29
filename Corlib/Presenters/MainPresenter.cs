using AutoMapper;
using Corlib.Builders;
using Corlib.Config;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Services.ServiceModels;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Corlib.Presenters
{
	public class MainPresenter : IMainPresenter
	{
		private readonly IMainView _view;
		private IUnitOfWork _unitOfWork;
		private MemberViewModel _selectedMember;
		private QuickStats _quickStats;

		public MainPresenter(IMainView view)
		{
			_view = view;
			ServiceLocator.SetView(GetView());

			StartPresenter();
		}

		#region IMainPresenter
		public void ShowView()
		{
			_view.ShowView();
		}

		public IView GetView()
		{
			return _view;
		}
		#endregion

		private void StartPresenter()
		{
			WireViewEvents();
			InitializeView();
			RefreshDashboardData();
			RefreshMembersList();
			RefreshCheckinsList();
			RefreshProductsList();
			RefreshSalesList();
			RefreshTrainersList();
			RefreshTrainingsList();
			SendDailyReportToSentry();
		}

		private void InitializeView()
		{
			_view.ViewText = $"{AppConfig.AppName} | {AppConfig.Parameters.Gym.Name}";
			_view.Username = AppConfig.User.Username.ToUpper();
		}

		private void WireViewEvents()
		{
			_view.ViewLoaded += OnViewLoaded;
			_view.SelectedMemberChanged += OnSelectedMemberChanged;
			_view.ShowMember += OnShowMember;
			_view.DeleteMember += OnDeleteMember;
			_view.ShowProduct += OnShowProduct;
			_view.DeleteProduct += OnDeleteProduct;
			_view.ShowTrainer += OnShowTrainer;
			_view.DeleteTrainer += OnDeleteTrainer;
			_view.ShowTraining += OnShowTraining;
			_view.DeleteTraining += OnDeleteTraining;
			_view.NewCheckin += OnNewCheckin;
			_view.DeleteCheckin += OnDeleteCheckin;
			_view.RefreshDashboardData += OnRefreshDashboardData;
			_view.RefreshMembers += OnRefreshMembers;
			_view.RefreshCheckins += OnRefreshCheckins;
			_view.ShowMessages += OnShowMessages;
			_view.NewMessageToMember += OnNewMessageToMember;
			_view.ShowParameters += OnShowParameters;
			_view.ViewClosing += OnViewClosing;
			_view.ShowProductTypes += OnShowProductTypes;
			_view.NewSale += OnNewSale;
			_view.ShowShiftsAndQuotas += OnShowShiftsAndQuotas;
			_view.ShowReports += OnShowReports;
			_view.PrintProductsReport += OnPrintProductsReport;
			_view.PrintMemberInfoReport += OnPrintMemberInfo;
			_view.PrintMembersReport += OnPrintMembersReport;
			_view.ShowDeletedMembers += OnShowDeletedMembers;
			_view.ShowDatabaseBackupRecords += OnShowDatabaseBackupRecords;
			_view.ShowAdConfiguration += OnShowAdConfiguration;
			_view.ShowIMCCalculator += OnShowIMCCalculator;
			_view.ShowHelp += OnShowHelp;
			_view.ShowUserProfile += OnShowUserProfile;
			_view.ShowStatistics += OnShowStatistics;
		}

		private void OnViewLoaded()
		{
			UpdateMembershipsStatus();
			BackupDatabase();
		}

		private void OnShowMember(EventArgs<MemberViewModel> e)
		{
			PresenterBuilder<IMemberPresenter, IMemberView>.Build(e.Value).ShowView();
			RefreshMembersList();
		}

		private void OnDeleteMember(EventArgs<MemberViewModel> e)
		{
			if (e.Value == null)
				return;

			if (_view.Confirm($"¿Está seguro que desea eliminar al miembro {e.Value.FullName}?"))
			{
				ServiceLocator.RunnerService.Run(() =>
				{
					using (_unitOfWork = UnitOfWorkFactory.Create())
					{
						var member = _unitOfWork.Members.Get(e.Value.Id);
						_unitOfWork.Members.Delete(member);
						_unitOfWork.Complete();
						RefreshMembersList();
						_view.Notify("El miembro ha sido eliminado exitosamente", MessageType.Information);
					}
				}, "Ha ocurrido un error al intentar eliminar el miembro. Por favor, intente nuevamente.");
			}
		}

		private void OnShowProduct(EventArgs<ProductViewModel> e)
		{
			PresenterBuilder<IProductPresenter, IProductView>.Build(e.Value).ShowView();
			RefreshProductsList();
		}

		private void OnDeleteProduct(EventArgs<ProductViewModel> e)
		{
			if (e.Value == null)
				return;

			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				if (!_unitOfWork.Products.CanBeDeleted(e.Value.Id))
				{
					_view.Notify("El producto no puede ser eliminado ya que existen ventas asociadas al mismo", MessageType.Warning);
					return;
				}

				if (_view.Confirm($"¿Está seguro que desea eliminar el producto {e.Value.Name}?"))
				{
					ServiceLocator.RunnerService.Run(() =>
					{
						var product = _unitOfWork.Products.Get(e.Value.Id);

						_unitOfWork.Products.Remove(product);
						_unitOfWork.Complete();
						RefreshProductsList();
						_view.Notify("El producto ha sido eliminado exitosamente", MessageType.Information);

					}, "Ha ocurrido un error al intentar eliminar el producto. Por favor, intente nuevamente");
				}
			}
		}

		private void OnSelectedMemberChanged(object sender, EventArgs<MemberViewModel> e)
		{
			if (e != null && e.Value != null)
			{
				_selectedMember = e.Value;
				_view.SelectedMemberFullName = e.Value.FullName;
				_view.SelectedMemberDNI = e.Value.DNI.ToString();
				_view.SelectedMemberAddress = (string.IsNullOrEmpty(e.Value.Address) ? "" : e.Value.Address + " - ") + e.Value.CityName;
				_view.SelectedMemberMobilePhone = e.Value.MobilePhone;
				_view.SelectedMemberProfilePicturePath = File.Exists(e.Value.ProfilePicturePath) ? e.Value.ProfilePicturePath : null;
				_view.SelectedMemberProfilePictureSizeMode = e.Value.ProfilePictureSizeMode;

				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					var memberships = _unitOfWork.Memberships.Find(x => x.MemberId == e.Value.Id && x.Status == MembershipStatus.ACTIVE, "Training").OrderByDescending(x => x.Id);
					_view.SelectedMemberActiveMemberships = Mapper.Map<IEnumerable<MembershipViewModel>>(memberships);
					_view.SelectedMemberLastCheckin = _unitOfWork.Members.GetLastCheckin(e.Value.Id);
					_view.SelectedMemberTotalCheckins = _unitOfWork.Members.GetTotalCheckins(e.Value.Id);
				}
			}
		}

		private void OnShowTrainer(EventArgs<TrainerViewModel> e)
		{
			PresenterBuilder<ITrainerPresenter, ITrainerView>.Build(e.Value).ShowView();
			RefreshTrainersList();
		}

		private void OnDeleteTrainer(EventArgs<TrainerViewModel> e)
		{
			if (e.Value == null)
				return;

			if (_view.Confirm($"¿Está seguro que desea eliminar al entrenador {e.Value.FullName}?"))
			{
				ServiceLocator.RunnerService.Run(() =>
				{
					using (_unitOfWork = UnitOfWorkFactory.Create())
					{
						var trainer = _unitOfWork.Trainers.Get(e.Value.Id);
						_unitOfWork.Trainers.Delete(trainer);
						_unitOfWork.Complete();
						RefreshTrainersList();
						_view.Notify("El entrenador ha sido eliminado exitosamente", MessageType.Information);
					}
				}, "Ha ocurrido un error al intentar eliminar el entrenador. Por favor, intente nuevamente");
			}
		}

		private void OnDeleteTraining(EventArgs<TrainingViewModel> e)
		{
			if (e.Value == null)
				return;

			if (_view.Confirm($"¿Está seguro que desea eliminar la actividad {e.Value.Name}?"))
			{
				try
				{
					using (_unitOfWork = UnitOfWorkFactory.Create())
					{
						var training = _unitOfWork.Trainings.Get(e.Value.Id);
						_unitOfWork.Trainings.Delete(training);
						_unitOfWork.Complete();
						RefreshTrainingsList();
						_view.Notify("La actividad ha sido eliminada exitosamente", MessageType.Information);
					}
				}
				catch (Exception ex)
				{
					_view.Notify("Ha ocurrido un error al intentar eliminar la actividad. Por favor, intente nuevamente", MessageType.Error);
					ServiceLocator.SentryService.ReportError(ex);
				}
			}
		}

		private void OnNewCheckin(EventArgs<MemberViewModel> e)
		{
			PresenterBuilder<ICheckinPresenter, ICheckinView>.Build(e.Value).ShowView();
			RefreshCheckinsList();
		}

		private void OnDeleteCheckin(int id)
		{
			if (_view.Confirm("¿Está seguro que desea eliminar la asistencia seleccionada?"))
			{
				ServiceLocator.RunnerService.Run(() =>
				{
					using (_unitOfWork = UnitOfWorkFactory.Create())
					{
						var checkin = _unitOfWork.Checkins.Get(id);
						_unitOfWork.Checkins.Remove(checkin);
						_unitOfWork.Complete();
						RefreshCheckinsList();
						_view.Notify("La asistencia ha sido eliminada exitosamente", MessageType.Information);
					}
				}, "Ha ocurrido un error al intentar eliminar la asistencia. Por favor, intente nuevamente.");
			}
		}

		private void OnRefreshDashboardData()
		{
			RefreshDashboardData();
		}

		private void OnRefreshMembers()
		{
			RefreshMembersList();
		}

		private void OnRefreshCheckins()
		{
			RefreshCheckinsList();
		}

		private void OnShowTraining(EventArgs<TrainingViewModel> e)
		{
			PresenterBuilder<ITrainingPresenter, ITrainingView>.Build(e.Value).ShowView();
			RefreshTrainingsList();
		}

		private void OnShowMessages()
		{
			PresenterBuilder<IMessagesPresenter, IMessagesView>.Build().ShowView();
		}

		private void OnNewMessageToMember(EventArgs<MemberViewModel> e)
		{
			PresenterBuilder<IMessagePresenter, IMessageView>.Build(e.Value).ShowView();
		}

		private void OnShowParameters()
		{
			var presenter = PresenterBuilder<IParametersPresenter, IParametersView>.Build();
			presenter.ShowView();

			if (presenter.ParametersChanged)
				_view.Notify("Para que los cambios surtan efecto, por favor cierre y vuelva a abrir la aplicación.", MessageType.Information);
		}

		private bool OnViewClosing()
		{
			SaveParameters();

			return _view.Confirm("¿Está seguro que desea cerrar la aplicación?");
		}

		private void OnShowProductTypes()
		{
			PresenterBuilder<IProductTypesPresenter, IProductTypesView>.Build().ShowView();
		}

		private void OnNewSale()
		{
			PresenterBuilder<INewSalePresenter, INewSaleView>.Build(null).ShowView();
			RefreshSalesList();
		}

		private void OnShowShiftsAndQuotas()
		{
			PresenterBuilder<IShiftsAndQuotasPresenter, IShiftsAndQuotasView>.Build().ShowView();
		}

		private void OnShowReports()
		{
			PresenterBuilder<IReportConfigurationPresenter, IReportConfigurationView>.Build().ShowView();
		}

		private void OnPrintProductsReport()
		{
			var config = new ReportConfigurationViewModel
			{
				ViewText = "Productos",
				Report = Report.Products,
				DataMember = "Query"
			};

			PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
		}

		private void OnPrintMemberInfo(int id)
		{
			var config = new ReportConfigurationViewModel
			{
				ViewText = "Ficha personal",
				Report = Report.MemberInfo,
				DataMember = "Query",
				Parameters = Helper.GetMemberReportParameters(id)
			};

			PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
		}

		private void OnPrintMembersReport()
		{
			var config = new ReportConfigurationViewModel
			{
				ViewText = "Miembros",
				Report = Report.Members,
				DataMember = "Query"
			};

			PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
		}

		private void OnShowDeletedMembers()
		{
			PresenterBuilder<IDeletedMembersPresenter, IDeletedMembersView>.Build().ShowView();
			RefreshMembersList();
		}

		private void OnShowDatabaseBackupRecords()
		{
			PresenterBuilder<IDatabaseBackupRecordsPresenter, IDatabaseBackupRecordsView>.Build().ShowView();
		}

		private void OnShowAdConfiguration()
		{
			PresenterBuilder<IAdConfigurationPresenter, IAdConfigurationView>.Build().ShowView();
		}

		private void OnShowIMCCalculator()
		{
			PresenterBuilder<IBMICalculatorPresenter, IBMICalculatorView>.Build().ShowView();
		}

		private void OnShowHelp()
		{
			string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "help", "index.html");

			if (!File.Exists(path))
				_view.Notify($"Ha ocurrido un error al intentar abrir la ayuda. No se ha encontrado el archivo {path}", MessageType.Error);

			Process.Start(path);
		}

		private void OnShowUserProfile()
		{
			PresenterBuilder<IUserProfilePresenter, IUserProfileView>.Build().ShowView();
		}

		private void OnShowStatistics()
		{
			PresenterBuilder<IStatisticsPresenter, IStatisticsView>.Build().ShowView();
		}

		private void SaveParameters()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var parameters = _unitOfWork.Parameters.Get();
				parameters.SplitContainerMembersVerticalSplitterPosition = AppConfig.Parameters.SplitContainerMembersVerticalSplitterPosition;
				parameters.SplitContainerMembersHorizontalSplitterPosition = AppConfig.Parameters.SplitContainerMembersHorizontalSplitterPosition;
				_unitOfWork.Complete();
			}
		}

		private void RefreshDashboardData()
		{
			_view.CheckinsSeriesData = ServiceLocator.StatisticsService.GetCheckinSeriesData(30);
			_view.MembershipsSeriesData = ServiceLocator.StatisticsService.GetMembershipsSeriesData();
			_view.WeekBirthdays = ServiceLocator.StatisticsService.GetWeekBirthdays();

			_quickStats = ServiceLocator.StatisticsService.GetQuickStats(QuickStatsOption.TotalMembers | QuickStatsOption.ActiveMembers
																| QuickStatsOption.DailyAverageCheckins | QuickStatsOption.MonthlyAverageCheckins
																| QuickStatsOption.MostPopularTraining
																| QuickStatsOption.MostSoldProduct);

			_view.TotalMembers = _quickStats.TotalMembers;
			_view.ActiveMembers = _quickStats.ActiveMembersPercentage;
			_view.DailyAverageCheckins = _quickStats.DailyAverageCheckins;
			_view.MonthlyAverageCheckins = _quickStats.MonthlyAverageCheckins;
			_view.MostPopularTraining = _quickStats.MostPopularTraining;
			_view.MostSoldProduct = _quickStats.MostSoldProduct;
		}

		private void RefreshMembersList()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var members = _unitOfWork.Members.Find(x => !x.IsDeleted, "City");
				var membersViewModels = Mapper.Map<IEnumerable<Member>, IEnumerable<MemberViewModel>>(members);
				_view.Members = membersViewModels;
			}
		}

		private void RefreshCheckinsList()
		{
			ServiceLocator.RunnerService.Run(() =>
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					var checkins = _unitOfWork.Checkins.GetAll(x => x.Id, false, 100, "Membership", "Membership.Member", "Membership.Training");
					var checkinsViewModels = Mapper.Map<IEnumerable<Checkin>, IEnumerable<CheckinViewModel>>(checkins);
					_view.Checkins = checkinsViewModels;
				}
			}, "Ha ocurrido un error al intentar refrescar la lista de asistencias.");
		}

		private void RefreshProductsList()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var products = _unitOfWork.Products.GetAll("ProductType");
				var productsViewModels = Mapper.Map<IEnumerable<ProductViewModel>>(products);

				_view.Products = productsViewModels;
			}
		}

		private void RefreshSalesList()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var sales = _unitOfWork.Sales.GetAll("Member", "SaleItems", "SaleItems.Product");
				var salesViewModels = Mapper.Map<IEnumerable<SaleViewModel>>(sales);

				_view.Sales = salesViewModels;
			}
		}

		private void RefreshTrainersList()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var trainers = _unitOfWork.Trainers.Find(x => !x.IsDeleted, "City");
				var trainersViewModels = Mapper.Map<IEnumerable<Trainer>, IEnumerable<TrainerViewModel>>(trainers);

				_view.Trainers = trainersViewModels;
			}
		}

		private void RefreshTrainingsList()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var trainings = _unitOfWork.Trainings.Find(x => !x.IsDeleted, "Trainers", "Shifts");
				var trainingsViewModels = Mapper.Map<IEnumerable<Training>, IEnumerable<TrainingViewModel>>(trainings);

				_view.Trainings = trainingsViewModels;
			}
		}

		private void SendDailyReportToSentry()
		{
			ServiceLocator.SentryService.ReportStatus(AppConfig.Parameters.Gym.Name, AppConfig.User.Username, _quickStats);
		}

		private void BackupDatabase()
		{
			_view.StatusBarMessage = "Realizando backup de la base de datos. Por favor, espere..";

			ServiceLocator.RunnerService.Run(() =>
			{
				ServiceLocator.DatabaseBackupService.Backup();
			}, "Ha ocurrido un error al intentar realizar la copia de seguridad de la base de datos.");

			_view.StatusBarMessage = "";
		}

		private void UpdateMembershipsStatus()
		{
			_view.StatusBarMessage = "Actualizando el estado de las membresías. Por favor, espere..";

			ServiceLocator.RunnerService.Run(() =>
			{
				ServiceLocator.MembershipsService.DeactivateExpiredMemberships();
			}, "Ha ocurrido un error al actualizar el estado de las membresías.");

			_view.StatusBarMessage = "";
		}
	}
}
