using Corlib.Builders;
using Corlib.Config;
using Corlib.Core;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;

namespace Corlib.Presenters
{
   public class MemberLoginPresenter : IMemberLoginPresenter
   {
      private readonly IMemberLoginView _view;
      private IUnitOfWork _unitOfWork;

      public MemberLoginPresenter(IMemberLoginView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         InitializeView();
      }

      #region IMemberLoginPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void InitializeView()
      {
         _view.ViewText = $"{AppConfig.AppName} | {AppConfig.Parameters.Gym.Name}";
      }

      private void WireViewEvents()
      {
         _view.Login += OnLogin;
      }

      private void OnLogin(int dni)
      {
         ServiceLocator.RunnerService.Run(() =>
         {
            using (_unitOfWork = UnitOfWorkFactory.Create())
            {
               var member = _unitOfWork.Members.Get(x => x.DNI == dni && !x.IsDeleted);

               if (dni == 66666666)
                  _view.ShowAboutView();

               if (member != null)
               {
                  _view.HideView();
                  PresenterBuilder<IMemberDashboardPresenter, IMemberDashboardView>.Build(dni).ShowView();
               }
               else
               {
                  _view.Notify("DNI incorrecto. Por favor, intenta otra vez.", MessageType.Error);
               }
            }
         }, () =>
          {
             _view.ShowErrorMessage("Ha ocurrido un error inesperado. Por favor, intenta nuevamente.");
          }
         );
      }
   }
}
