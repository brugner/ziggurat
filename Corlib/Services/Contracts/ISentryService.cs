using Corlib.Services.ServiceModels;
using System;

namespace Corlib.Services.Contracts
{
   public interface ISentryService
   {
      void ReportError(Exception ex);
      void ReportInfo(string message);
      void ReportStatus(string gym, string username, QuickStats quickStats);
   }
}
