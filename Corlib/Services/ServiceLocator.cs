using Corlib.Services.Contracts;
using Corlib.Views.Contracts;

namespace Corlib.Services
{
   public class ServiceLocator
   {
      private static IView _view;

      private static IMembershipsService _membershipsService;
      public static IMembershipsService MembershipsService
      {
         get
         {
            if (_membershipsService == null)
               _membershipsService = new MembershipsService();

            return _membershipsService;
         }
      }

      private static IStatisticsService _statisticsService;
      public static IStatisticsService StatisticsService
      {
         get
         {
            if (_statisticsService == null)
               _statisticsService = new StatisticsService();

            return _statisticsService;
         }
      }

      private static IRunnerService _runnerService;
      public static IRunnerService RunnerService
      {
         get
         {
            if (_runnerService == null)
               _runnerService = new RunnerService();

            return _runnerService;
         }
      }

      private static IMessagingService _messagingService;
      public static IMessagingService MessagingService
      {
         get
         {
            if (_messagingService == null)
               _messagingService = new MessagingService(_view);

            return _messagingService;
         }
      }

      private static ISentryService _sentryService;
      public static ISentryService SentryService
      {
         get
         {
            if (_sentryService == null)
               _sentryService = new SentryService();

            return _sentryService;
         }
      }

      private static IAuthenticationService _authenticationService;
      public static IAuthenticationService AuthenticationService
      {
         get
         {
            if (_authenticationService == null)
               _authenticationService = new AuthenticationService();

            return _authenticationService;
         }
      }

      private static IDatabaseBackupService _databaseBackupService;
      public static IDatabaseBackupService DatabaseBackupService
      {
         get
         {
            if (_databaseBackupService == null)
               _databaseBackupService = new DatabaseBackupService();

            return _databaseBackupService;
         }
      }

      private ServiceLocator()
      {

      }

      public static void SetView(IView view)
      {
         _view = view;
      }
   }
}
