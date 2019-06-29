using Corlib.Builders;
using Corlib.Config;
using Corlib.Presenters;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Management;
using Management.Auth;
using Management.Misc;
using System;
using System.Windows.Forms;

namespace WinFormsClient
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			bool initError = false;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (DatabaseInstaller.Start() > 0)
				return;

			ServiceLocator.RunnerService.Run(() =>
			{
				AppConfig.Initialize();
			}, () =>
			{
				MessageBox.Show("Ha ocurrido un error al inicializar la configuración de la aplicación. No es posible continuar.", "Ziggurat Gym Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
				initError = true;
			});

			if (!initError)
			{
				if (AppConfig.Environment.IsProduction)
				{
					var view = new LoginView();
					var splash = new SplashScreenView();
					var presenter = new LoginPresenter(view, splash);
					Application.Run(view);
				}
				else
				{
					AppConfig.User = new LoggedInUser(Environment.UserName);
					PresenterBuilder<IMainPresenter, IMainView>.Build().ShowView();
					Application.Run();
				}
			}
		}
	}
}
