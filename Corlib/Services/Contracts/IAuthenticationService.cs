using Corlib.Services.ServiceModels;

namespace Corlib.Services.Contracts
{
	public interface IAuthenticationService
	{
		LoginResult Login(string username, string password);
		bool IsCurrentPasswordOK(string currentPassword);
		void ChangePassword(string username, string newPassword);
	}
}
