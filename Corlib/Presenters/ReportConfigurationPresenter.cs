using AutoMapper;
using Corlib.Builders;
using Corlib.Core;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;

namespace Corlib.Presenters
{
   class ReportConfigurationPresenter : IReportConfigurationPresenter
   {
      private readonly IReportConfigurationView _view;
      private IUnitOfWork _unitOfWork;

      private List<string> ViewsText = new List<string>
      {
         "Miembros",
         "Asistencias",
         "Ventas",
         "Productos",
         "Deudores"
      };

      public ReportConfigurationPresenter(IReportConfigurationView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadRelatedData();
      }

      #region IReportCofigurationPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void WireViewEvents()
      {
         _view.ShowReport += OnShowReport;
      }

      private void OnShowReport()
      {
         ServiceLocator.RunnerService.Run(() =>
         {
            var config = new ReportConfigurationViewModel
            {
               ViewText = GetViewText(),
               Report = _view.SelectedReport,
               DataMember = GetDataMember(),
               Parameters = GetParameters()
            };

            PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
         }, "Ha ocurrido un error al intentar generar el reporte. Por favor, intente nuevamente.");
      }

      #region Helpers
      private void LoadRelatedData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _view.Trainings = Mapper.Map<IEnumerable<TrainingViewModel>>(_unitOfWork.Trainings.GetAll());
         }
      }

      private string GetViewText()
      {
         return ViewsText[(int)_view.SelectedReport];
      }

      private string GetDataMember()
      {
         switch (_view.SelectedReport)
         {
            case Report.Checkins:
               return "MainData";

            case Report.Members:
            case Report.MemberInfo:
            case Report.Products:
            case Report.RedOnes:
               return "Query";

            case Report.Sales:
               return "Sales";

            default:
               throw new Exception($"No hay DataMember para el reporte {Enum.GetName(typeof(Report), _view.SelectedReport)}");
         }
      }

      private Parameter[] GetParameters()
      {
         var parameters = new List<Parameter>();

         if (_view.SelectedReport == Report.Checkins)
         {
            parameters.Add(new Parameter() { Name = "ReportTitle", Value = $"Asistencias {_view.CheckinsDateFrom.ToString("dd/MM/yyyy")} - {_view.CheckinsDateTo.ToString("dd/MM/yyyy")}" });
            parameters.Add(new Parameter() { Name = "From", Value = new DateTime(_view.CheckinsDateFrom.Year, _view.CheckinsDateFrom.Month, _view.CheckinsDateFrom.Day) });
            parameters.Add(new Parameter() { Name = "To", Value = new DateTime(_view.CheckinsDateTo.Year, _view.CheckinsDateTo.Month, _view.CheckinsDateTo.Day) });

            var trainingsIds = new List<int>();
            foreach (var training in _view.SelectedTrainings)
               trainingsIds.Add(training.Id);

            parameters.Add(new Parameter() { Name = "TrainingsIds", MultiValue = true, Value = trainingsIds.ToArray() });
         }

         if (_view.SelectedReport == Report.Sales)
         {
            parameters.Add(new Parameter() { Name = "ReportTitle", Value = $"Ventas {_view.SalesDateFrom.ToString("dd/MM/yyyy")} - {_view.SalesDateTo.ToString("dd/MM/yyyy")}" });
            parameters.Add(new Parameter() { Name = "From", Value = new DateTime(_view.SalesDateFrom.Year, _view.SalesDateFrom.Month, _view.SalesDateFrom.Day) });
            parameters.Add(new Parameter() { Name = "To", Value = new DateTime(_view.SalesDateTo.Year, _view.SalesDateTo.Month, _view.SalesDateTo.Day) });
         }

         return parameters.ToArray();
      }
      #endregion
   }
}
