using System;

namespace Corlib.Extensions
{
   public static class DateTimeExtensions
   {
      public static int GetAge(this DateTime dateOfBirth, DateTime? dateAsToday = null)
      {
         if (!dateAsToday.HasValue)
            dateAsToday = DateTime.Today;

         return dateAsToday.Value.Year - dateOfBirth.Year - (dateOfBirth.DayOfYear < dateAsToday.Value.DayOfYear ? 0 : 1);
      }

      public static string ToAgeString(this DateTime dob)
      {
         var today = DateTime.Today;

         int months = today.Month - dob.Month;
         int years = today.Year - dob.Year;

         if (today.Day < dob.Day)
            months--;

         if (months < 0)
         {
            years--;
            months += 12;
         }

         int days = (today - dob.AddMonths((years * 12) + months)).Days;

         return string.Format("{0} año{1}, {2} mes{3} y {4} día{5}",
                              years, (years == 1) ? "" : "s",
                              months, (months == 1) ? "" : "es",
                              days, (days == 1) ? "" : "s");
      }
   }
}
