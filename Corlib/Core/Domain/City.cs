using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class City
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public string ZipCode { get; set; }
      public int StateId { get; set; }
      public virtual State State { get; set; }
      public virtual ICollection<Member> Members { get; set; }

      public City()
      {
         Members = new HashSet<Member>();
      }

      public City(string name, string zipCode, State state) : this()
      {
         Name = name;
         ZipCode = zipCode;
         State = state;
      }
   }
}
