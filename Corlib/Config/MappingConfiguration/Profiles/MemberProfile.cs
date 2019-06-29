using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Extensions;
using Corlib.Views.ViewModels;
using System;
using System.Globalization;

namespace Corlib.Config.MappingConfiguration.Profiles
{
	class MemberProfile : Profile
	{
		public MemberProfile()
		{
			CreateMap<Member, MemberViewModel>()
				 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
				 .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
				 .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
				 .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))

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

			CreateMap<Member, BirthdayViewModel>()
			  .ForMember(dest => dest.Member, opt => opt.ResolveUsing(src =>
			  {
				  return $"{src.FirstName} {src.LastName} ({GetAge(src.DateOfBirth)})";
			  }))
			  .ForMember(dest => dest.DayName, opt => opt.ResolveUsing(src =>
			  {
				  var ci = new CultureInfo("ES-AR");
				  var date = new DateTime(DateTime.Today.Year, src.DateOfBirth.Month, src.DateOfBirth.Day);
				  var dayName = ci.DateTimeFormat.GetDayName(date.DayOfWeek) + " " + date.Day;
				  return src.DateOfBirth.Day.ToString("D2") + "/" + src.DateOfBirth.Month.ToString("D2");
			  }));
		}

		private int GetAge(DateTime dob)
		{
			int age = dob.GetAge();
			if (dob.Day >= DateTime.Today.Day) age++;
			return age;
		}
	}
}
