using System;

namespace Corlib.Core.Domain
{
   public class Ad
   {
      public int Id { get; set; }
      public string AdText { get; set; }
      public string Image1Path { get; set; }
      public byte Image1SizeMode { get; set; }
      public string Image2Path { get; set; }
      public byte Image2SizeMode { get; set; }
      public string Image3Path { get; set; }
      public byte Image3SizeMode { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
   }
}
