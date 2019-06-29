using Corlib.Views.ViewModels;

namespace Corlib.Extensions
{
   public static class DebtViewModelExtensions
   {
      public static bool IsMembership(this DebtViewModel value)
      {
         return "Membresía".Equals(value.Origin);
      }
   }
}
