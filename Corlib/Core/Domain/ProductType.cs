using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class ProductType
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public virtual ICollection<Product> Products { get; set; }
   }
}
