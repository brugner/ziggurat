using Corlib.Services.Contracts;
using System;

namespace Corlib.Services
{
   class RunnerService : IRunnerService
   {
      #region IRunnerService
      public void Run(Action action)
      {
         try
         {
            action?.Invoke();
         }
         catch (Exception ex)
         {
            ServiceLocator.MessagingService.Notify($"Ha ocurrido un error inesperado. A continuación los detalles:\n{ex.Message}", MessageType.Error);
         }
      }

      public void Run(Action action, Action callback)
      {
         try
         {
            action?.Invoke();
         }
         catch (Exception ex)
         {
            callback?.Invoke();
            ServiceLocator.SentryService.ReportError(ex);
         }
      }

      public void Run(Action action, string friendlyMessage)
      {
         try
         {
            action?.Invoke();
         }
         catch (Exception ex)
         {
            ServiceLocator.MessagingService.Notify(friendlyMessage, MessageType.Error);
            ServiceLocator.SentryService.ReportError(ex);
         }
      }
      #endregion
   }
}
