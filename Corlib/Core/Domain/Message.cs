using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Corlib.Core.Domain
{
   public class Message
   {
      public int Id { get; set; }
      public string InternalRecipients { get; set; }

      [NotMapped]
      public int[] Recipients
      {
         get
         {
            return !string.IsNullOrEmpty(InternalRecipients) ? Array.ConvertAll(InternalRecipients.Split(';'), int.Parse) : null;
         }
         set
         {
            var _data = value;

            if (_data != null)
               InternalRecipients = string.Join(";", _data.Select(p => p.ToString()).ToArray());
         }
      }

      public string Subject { get; set; }
      public string Body { get; set; }
      public DateTime Date { get; set; }

      public string InternalReadBy { get; set; }

      [NotMapped]
      public int[] ReadBy
      {
         get
         {
            return !string.IsNullOrEmpty(InternalReadBy) ? Array.ConvertAll(InternalReadBy.Split(';'), int.Parse) : null;
         }
         set
         {
            var _data = value;

            if (_data != null)
               InternalReadBy = string.Join(";", _data.Select(p => p.ToString()).ToArray());
         }
      }
      public Message()
      {

      }
   }
}
