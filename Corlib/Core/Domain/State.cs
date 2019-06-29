using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class State
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public virtual ICollection<City> Cities { get; set; }

      public State()
      {
         Cities = new HashSet<City>();
      }

      public State(string name) : this()
      {
         Name = name;
      }
   }
}
