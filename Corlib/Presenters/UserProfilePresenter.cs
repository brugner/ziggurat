using Corlib.Config;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;

namespace Corlib.Presenters
{
	class UserProfilePresenter : IUserProfilePresenter
	{
		private IUserProfileView _view;

		public UserProfilePresenter(IUserProfileView view)
		{
			_view = view;
			ServiceLocator.SetView(GetView());

			WireViewEvents();
		}

		#region IUserProfilePresenter
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
			_view.ChangePassword += OnChangePassword;
		}

		private void OnChangePassword()
		{
			if (_view.NewPassword.Length < 6)
			{
				_view.Notify("La contraseña nueva debe tener al menos 6 caracteres. Por favor, intenta nuevamente.", MessageType.Error);
				return;
			}

			bool result = ServiceLocator.AuthenticationService.IsCurrentPasswordOK(_view.CurrentPassword);

			if (!result)
			{
				_view.Notify("La contraseña actual es incorrecta. Por favor, intenta nuevamente.", MessageType.Error);
				return;
			}

			if (!_view.NewPassword.Equals(_view.ConfirmPassword))
			{
				_view.Notify("La nueva contraseña no coincide con su confirmación. Por favor, intenta nuevamente.", MessageType.Error);
				return;
			}

			if (_view.Confirm("¿Está seguro que desea cambiar la contraseña?"))
			{
				ServiceLocator.AuthenticationService.ChangePassword(AppConfig.User.Username, _view.NewPassword);
				_view.Notify("La contraseña ha sido cambiada exitosamente", MessageType.Information);
				_view.CloseView();
			}
		}
	}
}
