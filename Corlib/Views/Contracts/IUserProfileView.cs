using System;

namespace Corlib.Views.Contracts
{
	public interface IUserProfileView : IView
	{
		string CurrentPassword { get; set; }
		string NewPassword { get; set; }
		string ConfirmPassword { get; set; }

		event Action ChangePassword;
	}
}
