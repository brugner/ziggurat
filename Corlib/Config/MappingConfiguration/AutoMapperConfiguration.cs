using AutoMapper;
using Corlib.Config.MappingConfiguration.Profiles;

namespace Corlib.Config.MappingConfiguration
{
   class AutoMapperConfiguration
   {
      public static void Configure()
      {
         Mapper.Initialize(cfg =>
         {
            cfg.AddProfile(new MemberProfile());
            cfg.AddProfile(new CityProfile());
            cfg.AddProfile(new ContactProfile());
            cfg.AddProfile(new NoteProfile());
            cfg.AddProfile(new ParameterProfile());
            cfg.AddProfile(new TrainerProfile());
            cfg.AddProfile(new TrainingProfile());
            cfg.AddProfile(new MessageProfile());
            cfg.AddProfile(new ShiftProfile());
            cfg.AddProfile(new MembershipProfile());
            cfg.AddProfile(new CheckinProfile());
            cfg.AddProfile(new PaymentProfile());
            cfg.AddProfile(new ProductTypeProfile());
            cfg.AddProfile(new ProductProfile());
            cfg.AddProfile(new SaleProfile());
            cfg.AddProfile(new MemberFinancialMovementProfile());
            cfg.AddProfile(new PersonalTrainingRecordProfile());
            cfg.AddProfile(new DatabaseBackupRecordProfile());
         });
      }
   }
}
