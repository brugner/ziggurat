using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class ShiftProfile : Profile
   {
      public ShiftProfile()
      {
         CreateMap<Shift, ShiftViewModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
            .ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.Days))
            .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
            .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
            .ForMember(dest => dest.Quota, opt => opt.MapFrom(src => src.Quota))

            .ForMember(dest => dest.DisplayName, opt => opt.ResolveUsing(src =>
            {
               return Helper.GetShiftDisplayName(src.Number, src.Days, src.StartTime, src.EndTime, src.Quota);
            }))

            .ForMember(dest => dest.TrainingName, opt => opt.ResolveUsing(src =>
            {
               return src.Training?.Name;
            }))

            .ForMember(dest => dest.DaysNames, opt => opt.ResolveUsing(src =>
            {
               return Helper.GetDaysNames(src.Days);
            }));
      }
   }
}
