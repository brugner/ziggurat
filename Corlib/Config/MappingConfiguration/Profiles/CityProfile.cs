using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class CityProfile : Profile
   {
      public CityProfile()
      {
         CreateMap<City, CityViewModel>();
         CreateMap<City, CityViewModel>().ForMember(dest => dest.CityStateName, input => input.MapFrom(i => i.State.Name));

         CreateMap<CityViewModel, City>();
      }
   }
}
