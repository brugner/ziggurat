using DevExpress.DataAccess.Sql;
using System;
using System.Collections;
using System.Text;

namespace Corlib.Views.Reports
{
   public partial class CheckinsReport : DevExpress.XtraReports.UI.XtraReport
   {
      public CheckinsReport()
      {
         InitializeComponent();
      }

      private void CheckinsReport_DataSourceDemanded(object sender, EventArgs e)
      {
         var query = sqlDataSource1.Queries[0] as CustomSqlQuery;
         int count = (Parameters["TrainingsIds"].Value as IList).Count;

         if (count == 0)
            return;

         var builder = new StringBuilder();
         builder.Append('(');

         for (int i = 0; i < count; i++)
         {
            builder.Append((Parameters["TrainingsIds"].Value as IList)[i]);

            if (i != count - 1)
               builder.Append(',');
         }

         builder.Append(')');
         query.Sql += " AND [Trainings].[Id] IN " + builder.ToString();
         sqlDataSource1.RebuildResultSchema();
      }
   }
}
