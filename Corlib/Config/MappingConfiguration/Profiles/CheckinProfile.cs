using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class CheckinProfile : Profile
   {
      public CheckinProfile()
      {
         CreateMap<Checkin, CheckinViewModel>()
            .ForMember(dest => dest.Id, input => input.MapFrom(i => i.Id))
            .ForMember(dest => dest.Date, input => input.MapFrom(i => i.Date))

            .ForMember(dest => dest.MemberFullName, opt => opt.ResolveUsing(src =>
            {
               return src.Membership.Member.FirstName + " " + src.Membership.Member.LastName;
            }))

            .ForMember(dest => dest.ProfilePicturePath, opt => opt.ResolveUsing(src =>
            {
               return src.Membership.Member.ProfilePicturePath;
            }))

            .ForMember(dest => dest.TrainingName, opt => opt.ResolveUsing(src =>
            {
               return src.Membership.Training.Name;
            }));
      }
   }
}
