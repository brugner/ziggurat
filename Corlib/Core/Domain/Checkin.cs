using System;

namespace Corlib.Core.Domain
{
   public class Checkin
   {
      public int Id { get; set; }
      public int MembershipId { get; set; }
      public virtual Membership Membership { get; set; }
      public DateTime Date { get; set; }
   }
}
