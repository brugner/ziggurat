using Corlib.Config;
using Corlib.Services.Contracts;
using Corlib.Services.ServiceModels;
using NLog;
using SharpRaven;
using SharpRaven.Data;
using System;

namespace Corlib.Services
{
   class SentryService : ISentryService
   {
      private static Logger _logger = LogManager.GetCurrentClassLogger();
      private static RavenClient _ravenClient = new RavenClient("https://b0dc1bd4fac9493591d6fb9da72238a3:f0ebd193dbed4e4286429b12106c93d1@sentry.io/1193442");

      #region ISentryService
      public void ReportError(Exception exception)
      {
         Report(exception);
      }

      public void ReportInfo(string message)
      {
         Report(message);
      }

      public void ReportStatus(string gym, string username, QuickStats quickStats)
      {
         SentryEvent sentryEvent = new SentryEvent("New login")
         {
            Level = ErrorLevel.Info
         };

         if (AppConfig.Environment.IsProduction)
         {
            sentryEvent.Tags.Add("gym", gym);
            sentryEvent.Tags.Add("username", username);
            sentryEvent.Tags.Add("TotalMembers", quickStats.TotalMembers.ToString());
            sentryEvent.Tags.Add("ActiveMembersPercentage", quickStats.ActiveMembersPercentage.ToString());
            sentryEvent.Tags.Add("DailyAverageCheckins", quickStats.DailyAverageCheckins.ToString());
            sentryEvent.Tags.Add("MonthlyAverageCheckins", quickStats.MonthlyAverageCheckins.ToString());
            sentryEvent.Tags.Add("MostPopularTraining", quickStats.MostPopularTraining.ToString());
            sentryEvent.Tags.Add("MostSoldProduct", quickStats.MostSoldProduct.ToString());

            _ravenClient.ErrorOnCapture = ex => { _logger.Error(new Exception("An error ocurred trying to send data to Sentry", ex)); };
            _ravenClient.Capture(sentryEvent);
         }
      }
      #endregion

      private void Report(object something)
      {
         var exception = something as Exception;
         var message = something as string;
         SentryEvent sentryEvent;

         if (exception != null)
         {
            sentryEvent = new SentryEvent(exception);
            sentryEvent.Level = ErrorLevel.Error;
            _logger.Error(exception);
         }
         else
         {
            sentryEvent = new SentryEvent(message);
            sentryEvent.Level = ErrorLevel.Info;
         }

         if (AppConfig.Environment.IsProduction)
         {
            if (AppConfig.Parameters != null)
               sentryEvent.Tags.Add("gym", AppConfig.Parameters.Gym.Name);

            _ravenClient.ErrorOnCapture = ex => { _logger.Error(new Exception("An error ocurred trying to send data to Sentry", ex)); };
            _ravenClient.Capture(sentryEvent);
         }
      }
   }
}
