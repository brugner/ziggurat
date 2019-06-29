using Corlib.Config;
using Corlib.Presenters.Contracts;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System;
using System.Linq;

namespace Corlib.Builders
{
   public sealed class PresenterBuilder<P, V> where P : IPresenter where V : IView
   {
      public static P Build()
      {
         var viewType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(V).Name).FirstOrDefault();
         var presenterType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(P).Name).FirstOrDefault();

         if (!IsValidAssociation(presenterType, viewType))
            throw new Exception($"{presenterType.Name} and {viewType.Name} make an invalid association");

         V view = (V)Activator.CreateInstance(viewType);
         return (P)Activator.CreateInstance(presenterType, view);
      }

      public static P Build(ViewModel viewModel)
      {
         var viewType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(V).Name).FirstOrDefault();
         var presenterType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(P).Name).FirstOrDefault();

         if (!IsValidAssociation(presenterType, viewType))
            throw new Exception($"{presenterType.Name} and {viewType.Name} make an invalid association");

         V view = (V)Activator.CreateInstance(viewType);
         return (P)Activator.CreateInstance(presenterType, view, viewModel);
      }

      public static P Build(int entity)
      {
         var viewType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(V).Name).FirstOrDefault();
         var presenterType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(P).Name).FirstOrDefault();

         if (!IsValidAssociation(presenterType, viewType))
            throw new Exception($"{presenterType.Name} and {viewType.Name} make an invalid association");

         V view = (V)Activator.CreateInstance(viewType);
         return (P)Activator.CreateInstance(presenterType, view, entity);
      }

      public static P Build(ViewModel viewModel, int entityId)
      {
         var viewType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(V).Name).FirstOrDefault();
         var presenterType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(P).Name).FirstOrDefault();

         if (!IsValidAssociation(presenterType, viewType))
            throw new Exception($"{presenterType.Name} and {viewType.Name} make an invalid association");

         V view = (V)Activator.CreateInstance(viewType);
         return (P)Activator.CreateInstance(presenterType, view, viewModel, entityId);
      }

      public static P Build(ViewModel viewModel, int? entityId)
      {
         var viewType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(V).Name).FirstOrDefault();
         var presenterType = AppConfig.PresentersAndViewsTypes.Where(x => "I" + x.Name == typeof(P).Name).FirstOrDefault();

         if (!IsValidAssociation(presenterType, viewType))
            throw new Exception($"{presenterType.Name} and {viewType.Name} make an invalid association");

         V view = (V)Activator.CreateInstance(viewType);
         return (P)Activator.CreateInstance(presenterType, view, viewModel, entityId);
      }

      private static bool IsValidAssociation(Type presenterType, Type viewType)
      {
         string presenterName = presenterType.Name.Remove(presenterType.Name.Length - 9, 9);
         string viewName = viewType.Name.Remove(viewType.Name.Length - 4, 4);

         return presenterName.Equals(viewName);
      }
   }
}
