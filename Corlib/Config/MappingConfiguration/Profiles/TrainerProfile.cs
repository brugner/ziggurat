using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Extensions;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class TrainerProfile : Profile
   {
      public TrainerProfile()
      {
         CreateMap<Trainer, TrainerViewModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))

            .ForMember(dest => dest.FullName, opt => opt.ResolveUsing(src =>
            {
               return src.FirstName + " " + src.LastName;
            }))

            .ForMember(dest => dest.Age, opt => opt.ResolveUsing(src =>
            {
               return src.DateOfBirth.GetAge();
            }))

            .ForMember(dest => dest.MobilePhone, opt => opt.ResolveUsing(src =>
            {
               return src.MobilePhoneAreaCode.ToString() + src.MobilePhoneNumber.ToString();
            }))

            .ForMember(dest => dest.CityName, opt => opt.ResolveUsing(src =>
            {
               return src.City?.Name;
            }));

         CreateMap<TrainerViewModel, Trainer>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))

            .ForMember(dest => dest.FirstName, opt => opt.ResolveUsing(src =>
            {
               return src.FullName.Split(' ')[0];
            }))

            .ForMember(dest => dest.LastName, opt => opt.ResolveUsing(src =>
            {
               return src.FullName.Split(' ')[1];
            }));
      }
   }
}
