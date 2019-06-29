using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class NoteProfile : Profile
   {
      public NoteProfile()
      {
         CreateMap<Note, NoteViewModel>();
         CreateMap<NoteViewModel, Note>();
      }
   }
}
