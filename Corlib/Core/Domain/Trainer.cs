using System;
using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class Trainer
   {
      public int Id { get; set; }
      public int DNI { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public DateTime DateOfBirth { get; set; }
      public string Gender { get; set; }
      public string Address { get; set; }
      public int CityId { get; set; }
      public virtual City City { get; set; }
      public int? MobilePhoneAreaCode { get; set; }
      public long? MobilePhoneNumber { get; set; }
      public string HomePhone { get; set; }
      public string Email { get; set; }
      public DateTime JoiningDate { get; set; }
      public DateTime UpdatedAt { get; set; }
      public bool IsDeleted { get; set; }
      public DateTime? DeletedAt { get; set; }
      public string ProfilePicturePath { get; set; }
      public byte ProfilePictureSizeMode { get; set; }
      public virtual ICollection<Training> Trainings { get; set; }

      public Trainer()
      {
         Trainings = new List<Training>();
      }
   }
}
