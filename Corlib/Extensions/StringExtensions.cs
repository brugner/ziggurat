using System;
using System.Text;

namespace Corlib.Extensions
{
   public static class StringExtensions
   {
      public static string CapitalizeFirstLetter(this string s)
      {
         if (string.IsNullOrEmpty(s)) return s;
         if (s.Length == 1) return s.ToUpper();
         return s.Remove(1).ToUpper() + s.Substring(1);
      }

      public static string Truncate(this string value, int maxLength)
      {
         if (string.IsNullOrEmpty(value)) return value;
         return value.Length <= maxLength ? value : value.Substring(0, maxLength);
      }

      public static string Encode(this string value)
      {
         if (string.IsNullOrEmpty(value)) return value;
         return Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
      }

      public static string Decode(this string value)
      {
         if (string.IsNullOrEmpty(value)) return value;
         return Encoding.UTF8.GetString(Convert.FromBase64String(value));
      }
   }
}
