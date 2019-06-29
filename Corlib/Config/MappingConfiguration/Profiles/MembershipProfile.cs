using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;
using System.Linq;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class MembershipProfile : Profile
   {
      public MembershipProfile()
      {
         CreateMap<Membership, MembershipViewModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
            .ForMember(dest => dest.StatusCode, opt => opt.MapFrom(src => src.Status))

            .ForMember(dest => dest.TrainingName, opt => opt.ResolveUsing(src =>
            {
               return src.Training.Name;
            }))

            .ForMember(dest => dest.StatusName, opt => opt.ResolveUsing(src =>
            {
               return src.Status == MembershipStatus.ACTIVE ? "Activa" : "Vencida";
            }));

         CreateMap<Membership, DebtViewModel>()
            .ForMember(dest => dest.IsSelected, opt => opt.MapFrom(x => false))
            .ForMember(dest => dest.MembershipId, opt => opt.MapFrom(x => x.Id))
            .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.EndDate))
            .ForMember(dest => dest.Origin, opt => opt.MapFrom(x => "Membresía"))
            .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Price))

            .ForMember(dest => dest.Description, opt => opt.ResolveUsing(src =>
            {
               return $"{src.Training.Name} {src.StartDate.ToString("dd/MM/yyyy")}-{src.EndDate.ToString("dd/MM/yyyy")}";
            }))

            .ForMember(dest => dest.DebtAmount, opt => opt.ResolveUsing(src =>
            {
               var payed = src.Payments.Sum(x => x.Amount);
               return src.Price - payed;
            }));
      }
   }
}
