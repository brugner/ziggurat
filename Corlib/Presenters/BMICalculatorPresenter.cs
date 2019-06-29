using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using System;
using System.Diagnostics;

namespace Corlib.Presenters
{
   class BMICalculatorPresenter : IBMICalculatorPresenter
   {
      private IBMICalculatorView _view;

      public BMICalculatorPresenter(IBMICalculatorView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
      }

      #region IBMICalculatorPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void WireViewEvents()
      {
         _view.CalculateBMI += OnCalculateBMI;
         _view.CalculateCalories += OnCalculateCalories;
         _view.MoreInfo += OnMoreInfo;
      }

      private decimal OnCalculateBMI(decimal weight, decimal height)
      {
         return Math.Round((weight / (height * height)) * 10000, 4);
      }

      private decimal OnCalculateCalories(decimal weight, byte activityLevel)
      {
         return Math.Round((weight * 2.2m) * GetCoeficient(activityLevel), 2);
      }

      private void OnMoreInfo()
      {
         Process.Start("http://es.wikipedia.org/wiki/%C3%8Dndice_de_masa_corporal");
      }

      private decimal GetCoeficient(byte activityLevel)
      {
         switch (activityLevel)
         {
            case 1:
               return 12;

            case 2:
               return 13.5M;

            case 3:
               return 15.5M;

            case 4:
               return 17;

            case 5:
            default:
               return 19;
         }
      }

   }
}
