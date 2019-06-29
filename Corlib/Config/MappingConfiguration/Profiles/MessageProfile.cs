using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class MessageProfile : Profile
   {
      public MessageProfile()
      {
         CreateMap<Message, MessageViewModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
             .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
             .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body))
             .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
             .ForMember(dest => dest.RecipientsIds, opt => opt.MapFrom(src => src.Recipients))
             .ForMember(dest => dest.ReadByIds, opt => opt.MapFrom(src => src.ReadBy))
             .ForMember(dest => dest.RecipientsNames, opt => opt.Ignore())
             .ForMember(dest => dest.ReadByNames, opt => opt.Ignore());
      }
   }
}
