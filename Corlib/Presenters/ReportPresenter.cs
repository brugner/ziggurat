using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.Reports;
using Corlib.Views.ViewModels;
using DevExpress.XtraReports.UI;
using System;

namespace Corlib.Presenters
{
   class ReportPresenter : IReportPresenter
   {
      private readonly IReportView _view;
      private readonly ReportConfigurationViewModel _config;

      public ReportPresenter(IReportView view, ReportConfigurationViewModel config)
      {
         _view = view;
         _config = config;
         ServiceLocator.SetView(GetView());

         ServiceLocator.RunnerService.Run(() =>
         {
            var reportFile = CreateReportFile(config.Report);
            reportFile.DataMember = _config.DataMember;

            if (reportFile.Parameters.Count > 0)
               foreach (var parameter in _config.Parameters)
                  reportFile.Parameters[parameter.Name].Value = parameter.Value;

            _view.ViewText = config.ViewText;
            _view.ReportFile = reportFile;
         }, "Ha ocurrido un error al intentar emitir el reporte. Por favor, intenta nuevamente.");
      }

      #region IReportPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private XtraReport CreateReportFile(Report reportName)
      {
         switch (reportName)
         {
            case Report.Members:
               return new MembersReport();

            case Report.Checkins:
               return new CheckinsReport();

            case Report.Sales:
               return new SalesMasterReport();

            case Report.Products:
               return new ProductsReport();

            case Report.RedOnes:
               return new RedOnesReport();

            case Report.MemberInfo:
               return new MemberInfoReport();

            case Report.FinancialMovements:
               return new MemberFinancialMovementsReport();

            case Report.Receipt:
               return new ReceiptReport();

            case Report.PersonalTrainingRecords:
               return new PersonalTrainingRecordsReport();

            default:
               throw new Exception($"El reporte {Enum.GetName(typeof(Report), reportName)} no existe");
         }
      }
   }
}
