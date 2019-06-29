using Corlib;
using Corlib.Views.Contracts;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Management.Misc
{
   public partial class SplashScreenView : SplashScreen, ISplashScreenView
   {
      Timer timer = new Timer();

      public SplashScreenView()
      {
         InitializeComponent();
      }

      #region ISplashScreenView
      public void ShowView()
      {
         Show();
      }

      public void CloseView()
      {
         Close();
      }

      public void Notify(string message, MessageType type)
      {

      }

      public bool Confirm(string message)
      {
         return true;
      }

      public event Action ReadyToClose;
      #endregion

      private void SplashScreenView_Load(object sender, EventArgs e)
      {
         lbVersion.Text = $"Versión {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
         lbCopyright.Text = $"Brugnner © {DateTime.Today.Year}";
         lbLoadingMessage.Text = GetRandomMessage();

         timer.Interval = 2000;
         timer.Tick += new EventHandler(timer_Tick);
         timer.Start();
      }

      void timer_Tick(object sender, EventArgs e)
      {
         timer.Stop();
         ReadyToClose();
         Close();
      }

      private string GetRandomMessage()
      {
         var list = new List<string>
            {
                "Curvando el espacio-tiempo..",
                "Paciencia, esto está difícil..",
                "Encendiendo cohetes fase 2..",
                "Probando la paciencia del usuario..",
                "Haciendo correr al hámster..",
                "Cazando mamuts..",
                "Ajustando capacitor de flujo..",
                "Buscando a Wally..",
                "Soñando con una PC rápida..",
                "Alineando planetas..",
                "Contactando satélites.."
            };

         return list[new Random().Next(0, list.Count)];
      }
   }
}