using Corlib.Views.ViewModels;

namespace Corlib.Presenters.Contracts
{
   public interface ICitiesPresenter : IPresenter
   {
      CityViewModel SelectedCity { get; }
   }
}
