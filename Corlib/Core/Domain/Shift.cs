using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Corlib.Core.Domain
{
   public class Shift
   {
      public int Id { get; set; }
      public int TrainingId { get; set; }
      public virtual Training Training { get; set; }
      public int Number { get; set; }

      public string InternalDays { get; set; }

      [NotMapped]
      public int[] Days
      {
         get
         {
            return !string.IsNullOrEmpty(InternalDays) ? Array.ConvertAll(InternalDays.Split(';'), int.Parse) : null;
         }
         set
         {
            var _data = value;

            if (_data != null)
               InternalDays = string.Join(";", _data.Select(p => p.ToString()).ToArray());
         }
      }

      public DateTime StartTime { get; set; }
      public DateTime EndTime { get; set; }
      public byte? Quota { get; set; }
   }
}
