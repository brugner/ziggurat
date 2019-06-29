using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class PaymentProfile : Profile
   {
      public PaymentProfile()
      {
         CreateMap<Payment, PaymentViewModel>()
            .ForMember(dest => dest.Id, input => input.MapFrom(i => i.Id))
            .ForMember(dest => dest.Date, input => input.MapFrom(i => i.Date))
            .ForMember(dest => dest.Concept, input => input.MapFrom(i => i.Concept))
            .ForMember(dest => dest.Amount, input => input.MapFrom(i => i.Amount))
            .ForMember(dest => dest.Comment, input => input.MapFrom(i => i.Comment));
      }
   }
}
