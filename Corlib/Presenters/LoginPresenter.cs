using Corlib.Builders;
using Corlib.Config;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;

namespace Corlib.Presenters
{
   public class LoginPresenter : ILoginPresenter
   {
      private readonly ILoginView _view;
      private readonly ISplashScreenView _splashView;

      public LoginPresenter(ILoginView view, ISplashScreenView splashView)
      {
         _view = view;
         _splashView = splashView;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
      }

      #region ILoginPresenter
      public void ShowView()
      {

      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void WireViewEvents()
      {
         _view.Login += OnLogin;
         _splashView.ReadyToClose += OnSplashViewReadyToClose;
      }

      private void OnLogin(EventArgs<UserViewModel> e)
      {
         var result = ServiceLocator.AuthenticationService.Login(e.Value.Username, e.Value.Password);

         if (result.IsValid)
         {
            _view.HideView();
            _splashView.ShowView();

            AppConfig.User = new LoggedInUser(result.Username);
         }
         else
         {
            _view.LoginResultMessage = "Usuario o contraseña incorrectos";
         }
      }

      private void OnSplashViewReadyToClose()
      {
         PresenterBuilder<IMainPresenter, IMainView>.Build().ShowView();
      }
   }
}
