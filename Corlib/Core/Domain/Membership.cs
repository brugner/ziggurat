using System;
using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class Membership
   {
      public int Id { get; set; }
      public int MemberId { get; set; }
      public Member Member { get; set; }
      public int TrainingId { get; set; }
      public Training Training { get; set; }
      public int ShiftId { get; set; }
      public Shift Shift { get; set; }
      public int Length { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public decimal Price { get; set; }
      public byte Status { get; set; }
      public bool IsFullyPaid { get; set; }
      public virtual ICollection<Checkin> Checkins { get; set; }
      public virtual ICollection<Payment> Payments { get; set; }

      public Membership()
      {
         Checkins = new List<Checkin>();
         Payments = new List<Payment>();
      }
   }
}
