using DevExpress.XtraReports.UI;

namespace Corlib.Views.Contracts
{
   public interface IReportView : IView
   {
      string ViewText { set; }
      XtraReport ReportFile { set; }
   }
}
