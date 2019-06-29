namespace Corlib.Core.Domain
{
   public class Contact
   {
      public int Id { get; set; }
      public int MemberId { get; set; }
      public virtual Member Member { get; set; }
      public string Name { get; set; }
      public string PhoneNumber1 { get; set; }
      public string PhoneNumber2 { get; set; }
      public bool IsDoctor { get; set; }
   }
}