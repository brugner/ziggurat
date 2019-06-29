using System;
using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class Training
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal ClassPrice { get; set; }
      public decimal WeekPrice { get; set; }
      public decimal MonthPrice { get; set; }
      public decimal QuarterPrice { get; set; }
      public virtual ICollection<Trainer> Trainers { get; set; }
      public virtual ICollection<Shift> Shifts { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }
      public bool IsDeleted { get; set; }
      public DateTime? DeletedAt { get; set; }

      public Training()
      {
         Trainers = new List<Trainer>();
         Shifts = new List<Shift>();
      }
   }
}
