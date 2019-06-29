using Corlib.Core.Domain;
using Corlib.Persistence;
using FizzWare.NBuilder;
using System;
using System.Linq;

namespace Corlib.Migrations.SeedHelpers
{
   class MembersSeedHelper
   {
      private ZigguratContext _context;

      public MembersSeedHelper(ZigguratContext context)
      {
         _context = context;
      }

      internal Member[] GetMembers()
      {
         var members = Builder<Member>.CreateListOfSize(100)
           .All()
               .With(m => m.DNI = Faker.RandomNumber.Next(25000000, 42000000))
               .With(m => m.FirstName = Faker.Name.First())
               .With(m => m.LastName = Faker.Name.Last())
               .With(m => m.DateOfBirth = new DateTime(Faker.RandomNumber.Next(1963, 2002), Faker.RandomNumber.Next(1, 12), Faker.RandomNumber.Next(1, 28)))
               .With(m => m.Gender = Faker.RandomNumber.Next(0, 1) == 0 ? "M" : "F")
               .With(m => m.Address = Faker.Address.StreetAddress())
               .With(m => m.Email = Faker.Internet.Email())
               .With(m => m.MobilePhoneAreaCode = Faker.RandomNumber.Next(1000, 9999))
               .With(m => m.MobilePhoneNumber = Faker.RandomNumber.Next(100000, 999999))
               .With(m => m.HomePhone = Faker.Phone.Number())
               .With(m => m.ProfilePictureSizeMode = 1)
           .Build();

         return members.ToArray();
      }


   }
}
