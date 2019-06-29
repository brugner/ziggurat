using DevExpress.XtraReports.Parameters;

namespace Corlib.Views.ViewModels
{
   public class ReportConfigurationViewModel : ViewModel
   {
      public Report Report { get; set; }
      public string DataMember { get; set; }
      public string ViewText { get; internal set; }
      public Parameter[] Parameters { get; internal set; }
   }
}
