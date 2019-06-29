namespace Corlib.Views.ViewModels
{
   public class UserViewModel : ViewModel
   {
      public string Username { get; set; }
      public string Password { get; set; }

      public UserViewModel(string username, string password)
      {
         Username = username;
         Password = password;
      }
   }
}
