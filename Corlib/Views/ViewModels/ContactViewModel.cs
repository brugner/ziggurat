namespace Corlib.Views.ViewModels
{
   public class ContactViewModel : ViewModel
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public string PhoneNumber1 { get; set; }
      public string PhoneNumber2 { get; set; }
      public bool IsDoctor { get; set; }
   }
}
