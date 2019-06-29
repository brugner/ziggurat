namespace Corlib.Services.ServiceModels
{
    public class LoginResult
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public string Username { get; set; }

        public LoginResult(bool isValid, string message, string username) : this(isValid: isValid, message: message)
        {
            Username = username;
        }

        public LoginResult(bool isValid, string message)
        {
            IsValid = isValid;
            Message = message;
        }
    }
}
