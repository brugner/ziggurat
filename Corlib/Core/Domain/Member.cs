using System;
using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class Member
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
      public string Occupation { get; set; }
      public string Organization { get; set; }
      public string Conditions { get; set; }
      public string Medicine { get; set; }
      public bool Smoke { get; set; }
      public bool Alcohol { get; set; }
      public bool Diet { get; set; }
      public bool IsFirstTimeAtGym { get; set; }
      public string OtherSports { get; set; }
      public bool IsStudying { get; set; }
      public bool IsWorking { get; set; }
      public string Lead { get; set; }
      public DateTime JoiningDate { get; set; }
      public DateTime UpdatedAt { get; set; }
      public bool IsDeleted { get; set; }
      public DateTime? DeletedAt { get; set; }
      public string ProfilePicturePath { get; set; }
      public byte ProfilePictureSizeMode { get; set; }
      public virtual ICollection<Contact> Contacts { get; set; }
      public virtual ICollection<Note> Notes { get; set; }
      public virtual ICollection<Membership> Memberships { get; set; }
      public virtual ICollection<Sale> Sales { get; set; }
      public virtual ICollection<MemberFinancialMovement> FinancialMovements { get; set; }
      public virtual ICollection<PersonalTrainingRecord> PersonalTrainingRecords { get; set; }

      public Member()
      {
         Contacts = new List<Contact>();
         Notes = new List<Note>();
         Memberships = new List<Membership>();
         Sales = new List<Sale>();
         FinancialMovements = new List<MemberFinancialMovement>();
         PersonalTrainingRecords = new List<PersonalTrainingRecord>();
      }
   }
}
