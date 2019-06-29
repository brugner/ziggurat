namespace Corlib.Config
{
   public class LoggedInUser
   {
      public string Username { get; set; }

      public LoggedInUser(string username)
      {
         Username = username;
      }
   }
}
