using System;
using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class Product
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal Price { get; set; }
      public decimal Cost { get; set; }
      public int ProductTypeId { get; set; }
      public virtual ProductType ProductType { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }
      public bool IsActive { get; set; }
      public virtual ICollection<SaleItem> SaleItems { get; set; }
   }
}
