using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class ProductProfile : Profile
   {
      public ProductProfile()
      {
         CreateMap<Product, ProductViewModel>()
            .ForMember(dest => dest.Id, input => input.MapFrom(i => i.Id))
            .ForMember(dest => dest.Name, input => input.MapFrom(i => i.Name))
            .ForMember(dest => dest.Price, input => input.MapFrom(i => i.Price))
            .ForMember(dest => dest.IsActive, input => input.MapFrom(i => i.IsActive))

            .ForMember(dest => dest.ProductType, opt => opt.ResolveUsing(src =>
            {
               return src.ProductType.Name;
            }));
      }
   }
}
