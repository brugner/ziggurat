using Corlib.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Corlib
{
   class Helper
   {
      internal static string GetDaysNames(int[] days)
      {
         string result = string.Empty;

         if (days.Contains(0) && days.Contains(1) && days.Contains(2) && days.Contains(3) && days.Contains(4) && days.Contains(5) && days.Contains(6))
            return "Todos los días";

         if (days.Contains(0) && days.Contains(1) && days.Contains(2) && days.Contains(3) && days.Contains(4) && days.Contains(5))
            return "Lunes a sábado";

         if (days.Contains(0) && days.Contains(1) && days.Contains(2) && days.Contains(3) && days.Contains(4))
            return "Lunes a viernes";

         if (days.Contains(0))
            result += "lunes, ";
         if (days.Contains(1))
            result += "martes, ";
         if (days.Contains(2))
            result += "miércoles, ";
         if (days.Contains(3))
            result += "jueves, ";
         if (days.Contains(4))
            result += "viernes, ";
         if (days.Contains(5))
            result += "sábado, ";
         if (days.Contains(6))
            result += "domingo, ";

         return result.Remove(result.Length - 2).CapitalizeFirstLetter();
      }

      internal static string GetShiftDisplayName(int number, int[] days, DateTime startTime, DateTime endTime, byte? quota)
      {
         return $"#{number} | {GetDaysNames(days)} | {startTime.ToString("HH:mm")}hs-{endTime.ToString("HH:mm")}hs | "
            + (quota.HasValue ? $"Cupo: { quota.Value}" : "Cupo libre");
      }

      internal static string SavePictureAndGetPath(string imagePath, Entity entity, int? id)
      {
         if (string.IsNullOrEmpty(imagePath))
            return null;

         string entityName = "members";
         if (entity == Entity.Trainer) entityName = "trainers";
         if (entity == Entity.Ad) entityName = "ads";

         string sid = id.HasValue ? id.Value.ToString() : "";

         string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", entityName, sid);
         string fileName = Path.Combine(path, Guid.NewGuid() + Path.GetExtension(imagePath));

         Directory.CreateDirectory(path);
         File.Copy(imagePath, fileName, overwrite: true);

         return fileName;
      }

      internal static DevExpress.XtraReports.Parameters.Parameter[] GetMemberReportParameters(int memberId)
      {
         var parameters = new List<DevExpress.XtraReports.Parameters.Parameter>
         {
            new DevExpress.XtraReports.Parameters.Parameter { Name = "Id", Value = memberId }
         };

         return parameters.ToArray();
      }

      internal static DevExpress.XtraReports.Parameters.Parameter[] GetReceiptReportParameters(int paymentId)
      {
         return new List<DevExpress.XtraReports.Parameters.Parameter>
            {
               new DevExpress.XtraReports.Parameters.Parameter { Name = "Id", Value = paymentId }
            }.ToArray();
      }
   }
}
