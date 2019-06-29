using AutoMapper;
using Corlib.Core.Domain;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class ParameterProfile : Profile
   {
      public ParameterProfile()
      {
         CreateMap<Parameter, Parameters>()
            .ForMember(dest => dest.ValidationMessages,
               input => input.MapFrom(i => new ValidationMessages
               {
                  RequiredField = i.RequiredField,
                  InvalidEmailAddress = i.InvalidEmailAddress,
                  EnterAtLeastAPhone = i.EnterAtLeastAPhone,
                  EnterMobilePhoneAreaCode = i.EnterMobilePhoneAreaCode,
                  EnterPhoneNumber = i.EnterPhoneNumber,
                  SelectAtLeastOne = i.SelectAtLeastOne
               }))
            .ForMember(dest => dest.Gym,
              input => input.MapFrom(i => new Gym
              {
                 Name = i.GymName,
                 Address = i.GymAddress,
                 CityId = i.GymCityId,
                 Phone = i.GymPhone,
                 Email = i.GymAddress,
                 Facebook = i.GymFacebook,
                 Twitter = i.GymTwitter,
                 Instagram = i.GymInstagram
              }))
              .ForMember(dest => dest.Skin, input => input.MapFrom(i => i.Skin))
              .ForMember(dest => dest.SplitContainerMembersVerticalSplitterPosition, input => input.MapFrom(i => i.SplitContainerMembersVerticalSplitterPosition))
              .ForMember(dest => dest.SplitContainerMembersHorizontalSplitterPosition, input => input.MapFrom(i => i.SplitContainerMembersHorizontalSplitterPosition));
      }
   }
}
