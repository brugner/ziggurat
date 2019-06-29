using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class PersonalTrainingRecordProfile : Profile
   {
      public PersonalTrainingRecordProfile()
      {
         CreateMap<PersonalTrainingRecord, PersonalTrainingRecordViewModel>()
            .ForMember(dest => dest.Id, input => input.MapFrom(i => i.Id))
            .ForMember(dest => dest.MemberId, input => input.MapFrom(i => i.Member))
            .ForMember(dest => dest.Date, input => input.MapFrom(i => i.Date))
            .ForMember(dest => dest.Weight, input => input.MapFrom(i => i.Weight))
            .ForMember(dest => dest.Height, input => input.MapFrom(i => i.Height))
            .ForMember(dest => dest.Neck, input => input.MapFrom(i => i.Neck))
            .ForMember(dest => dest.Shoulders, input => input.MapFrom(i => i.Shoulders))
            .ForMember(dest => dest.Chest, input => input.MapFrom(i => i.Chest))
            .ForMember(dest => dest.Waist, input => input.MapFrom(i => i.Waist))
            .ForMember(dest => dest.Forearms, input => input.MapFrom(i => i.Forearms))
            .ForMember(dest => dest.Thighs, input => input.MapFrom(i => i.Thighs))
            .ForMember(dest => dest.Calves, input => input.MapFrom(i => i.Calves))
            .ForMember(dest => dest.Biceps, input => input.MapFrom(i => i.Biceps))
            .ForMember(dest => dest.Buttocks, input => input.MapFrom(i => i.Buttocks))
            .ForMember(dest => dest.Comment, input => input.MapFrom(i => i.Comment));
      }
   }
}
