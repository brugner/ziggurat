using DevExpress.XtraReports.UI;

namespace Corlib.Views.Reports
{
   public partial class RedOnesReport : XtraReport
   {
      public RedOnesReport()
      {
         InitializeComponent();

         var sql = sqlDataSource1;
      }

   }
}
