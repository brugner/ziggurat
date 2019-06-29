using AutoMapper;
using Corlib.Config.MappingConfiguration;
using Corlib.Core.Domain;
using Corlib.Exceptions;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Views.Contracts;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Corlib.Config
{
   public class AppConfig
   {
      private static Logger _logger = LogManager.GetCurrentClassLogger();

      public static string AppName { get => "Ziggurat"; }
      public static AppEnvironment Environment { get; }
      public static Parameters Parameters { get; set; }
      public static LoggedInUser User { get; set; }
      public static List<Type> PresentersAndViewsTypes { get; private set; }

      public static void Initialize()
      {
         _logger.Info("Initializing configuration..");

         AutoMapperConfiguration.Configure();
         LoadParametersFromDb();
         LoadPresentersAndViewsTypes();

         _logger.Info("Configuration initialized successfully!");
      }

      private static void LoadParametersFromDb()
      {
         using (var _unitOfWork = UnitOfWorkFactory.Create())
         {
            var paramsFromDb = _unitOfWork.Parameters.Get();
            Parameters = Mapper.Map<Parameter, Parameters>(paramsFromDb);

            if (Parameters == null)
               throw new ParametersNotFoundException();
         }
      }

      private static void LoadPresentersAndViewsTypes()
      {
         var presenterType = typeof(IPresenter);
         var viewType = typeof(IView);

         PresentersAndViewsTypes = GetRelevantAssemblies()
             .SelectMany(x => x.GetTypes())
             .Where(x => (presenterType.IsAssignableFrom(x) || viewType.IsAssignableFrom(x)) && !x.IsInterface).ToList();
      }

      private static Assembly[] GetRelevantAssemblies()
      {
         return AppDomain.CurrentDomain.GetAssemblies().Where(assembly => assembly.GetName().Name.Contains("Ziggurat")).ToArray();
      }
   }
}
