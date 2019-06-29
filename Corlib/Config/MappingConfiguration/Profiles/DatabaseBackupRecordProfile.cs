using AutoMapper;
using Corlib.Core.Domain;
using Corlib.Views.ViewModels;

namespace Corlib.Config.MappingConfiguration.Profiles
{
   class DatabaseBackupRecordProfile : Profile
   {
      public DatabaseBackupRecordProfile()
      {
         CreateMap<DatabaseBackupRecord, DatabaseBackupRecordViewModel>()
            .ForMember(dest => dest.Id, input => input.MapFrom(i => i.Id))
            .ForMember(dest => dest.Date, input => input.MapFrom(i => i.Date))
            .ForMember(dest => dest.Path, input => input.MapFrom(i => i.Path));
      }
   }
}
