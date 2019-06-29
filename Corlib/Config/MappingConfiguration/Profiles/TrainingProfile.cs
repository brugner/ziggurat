using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
	class TrainingProfile : Profile
	{
		public TrainingProfile()
		{
			CreateMap<Training, TrainingViewModel>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.ClassPrice, opt => opt.MapFrom(src => src.ClassPrice))
				.ForMember(dest => dest.WeekPrice, opt => opt.MapFrom(src => src.WeekPrice))
				.ForMember(dest => dest.MonthPrice, opt => opt.MapFrom(src => src.MonthPrice))
				.ForMember(dest => dest.QuarterPrice, opt => opt.MapFrom(src => src.QuarterPrice))
				.ForMember(dest => dest.Trainers, opt => opt.MapFrom(src => src.Trainers))
				 //.ForMember(dest => dest.Shifts, opt => opt.MapFrom(src => src.Shifts))
				 .ForMember(dest => dest.Shifts, opt => opt.ResolveUsing(src =>
				 {
					 return src.Shifts;
				 }))
				.AfterMap((t, tvm) =>
				{
					foreach (var trainer in t.Trainers)
						tvm.TrainersNames += trainer.FirstName + " " + trainer.LastName + "\n";

					foreach (var shift in t.Shifts)
						tvm.ShiftsSummary += Helper.GetShiftDisplayName(shift.Number, shift.Days, shift.StartTime, shift.EndTime, shift.Quota) + "\n";
				});
		}
	}
}