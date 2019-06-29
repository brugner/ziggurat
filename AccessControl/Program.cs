using AccessControl.MemberDashboard;
using AccessControl.MemberLogin;
using Corlib.Config;
using Corlib.Presenters;
using Corlib.Services;
using System;
using System.Windows.Forms;

namespace AccessControl
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
            var view = new MemberLoginView();
            var presenter = new MemberLoginPresenter(view);

            Application.Run(view);
         }
      }
   }
}
