using System;

namespace Corlib.Views.Contracts
{
   public interface IBMICalculatorView : IView
   {
      event Func<decimal, decimal, decimal> CalculateBMI;
      event Func<decimal, byte, decimal> CalculateCalories;
      event Action MoreInfo;
   }
}
