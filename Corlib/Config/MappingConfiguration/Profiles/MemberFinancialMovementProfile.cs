using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class MemberFinancialMovementProfile : Profile
   {
      public MemberFinancialMovementProfile()
      {
         CreateMap<MemberFinancialMovement, MemberFinancialMovementViewModel>()
            .ForMember(dest => dest.Id, input => input.MapFrom(i => i.Id))
            .ForMember(dest => dest.Date, input => input.MapFrom(i => i.Date))
            .ForMember(dest => dest.Concept, input => input.MapFrom(i => i.Concept))
            .ForMember(dest => dest.Debit, input => input.MapFrom(i => i.Debit))
            .ForMember(dest => dest.Credit, input => input.MapFrom(i => i.Credit))
            .ForMember(dest => dest.Balance, input => input.MapFrom(i => i.Balance));
      }
   }
}
