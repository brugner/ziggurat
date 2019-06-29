using Corlib.Core.Domain;
using Corlib.Persistence;
using FizzWare.NBuilder;
using System;
using System.Linq;

namespace Corlib.Migrations.SeedHelpers
{
   class TrainingsSeedHelper
   {
      private ZigguratContext _context;

      public TrainingsSeedHelper(ZigguratContext context)
      {
         _context = context;
      }

      internal Training[] GetTrainings()
      {
         var trainings = Builder<Training>.CreateListOfSize(5)
           .All()
               .With(t => t.Name = Faker.Name.First())
               .With(t => t.ClassPrice = Faker.RandomNumber.Next(50, 120))
               .With(t => t.WeekPrice = Faker.RandomNumber.Next(120, 250))
               .With(t => t.MonthPrice = Faker.RandomNumber.Next(400, 700))
               .With(t => t.QuarterPrice = Faker.RandomNumber.Next(1000, 3000))
               .With(t => t.Trainers = _context.Trainers.Where(x => x.Id == 1).ToList())
               .With(t => t.CreatedAt = DateTime.Now)
               .With(t => t.UpdatedAt = DateTime.Now)
               .With(t => t.IsDeleted = false)
               .With(t => t.DeletedAt = null)
           .Build();

         return trainings.ToArray();
      }
   }
}
