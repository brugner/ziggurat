using System;

namespace Corlib.Services.Contracts
{
   public interface IRunnerService
   {
      void Run(Action action);
      void Run(Action action, Action callback);
      void Run(Action action, string friendlyMessage);
   }
}