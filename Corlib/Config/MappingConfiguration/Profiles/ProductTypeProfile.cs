using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class ProductTypeProfile : Profile
   {
      public ProductTypeProfile()
      {
         CreateMap<ProductType, ProductTypeViewModel>()
            .ForMember(dest => dest.Id, input => input.MapFrom(i => i.Id))
            .ForMember(dest => dest.Name, input => input.MapFrom(i => i.Name));
      }
   }
}
