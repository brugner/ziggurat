using Corlib.Config;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Services.Contracts;
using Corlib.Services.ServiceModels;
using System;
using System.Security.Cryptography;

namespace Corlib.Services
{
	public class AuthenticationService : IAuthenticationService
	{
		private IUnitOfWork _unitOfWork;

		public LoginResult Login(string username, string password)
		{
			var user = GetUser(username);

			if (user == null)
				return new LoginResult(isValid: false, message: "Login failed");

			var passwordAndHashMatched = SecurePasswordHasher.Verify(password, user.PasswordHash);

			if (passwordAndHashMatched)
				return new LoginResult(isValid: true, message: "Login successful", username: user.Username);
			else
				return new LoginResult(isValid: false, message: "Login failed");
		}

		public bool IsCurrentPasswordOK(string currentPassword)
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var user = _unitOfWork.Users.Get(AppConfig.User.Username);
				return SecurePasswordHasher.Verify(currentPassword, user.PasswordHash);
			}
		}

		public void ChangePassword(string username, string newPassword)
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var user = _unitOfWork.Users.Get(AppConfig.User.Username);
				user.PasswordHash = SecurePasswordHasher.Hash(newPassword);
				_unitOfWork.Complete();
			}
		}

		private User GetUser(string username)
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				return _unitOfWork.Users.Get(username);
			}
		}

		private sealed class SecurePasswordHasher
		{
			/// <summary>
			/// Size of salt
			/// </summary>
			private const int SaltSize = 16;

			/// <summary>
			/// Size of hash
			/// </summary>
			private const int HashSize = 20;

			/// <summary>
			/// Creates a hash from a password
			/// </summary>
			/// <param name="password">the password</param>
			/// <param name="iterations">number of iterations</param>
			/// <returns>the hash</returns>
			public static string Hash(string password, int iterations)
			{
				//create salt
				byte[] salt;
				new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

				//create hash
				var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
				var hash = pbkdf2.GetBytes(HashSize);

				//combine salt and hash
				var hashBytes = new byte[SaltSize + HashSize];
				Array.Copy(salt, 0, hashBytes, 0, SaltSize);
				Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

				//convert to base64
				var base64Hash = Convert.ToBase64String(hashBytes);

				//format hash with extra information
				return string.Format("$MYHASH$V1${0}${1}", iterations, base64Hash);
			}
			/// <summary>
			/// Creates a hash from a password with 10000 iterations
			/// </summary>
			/// <param name="password">the password</param>
			/// <returns>the hash</returns>
			public static string Hash(string password)
			{
				return Hash(password, 10000);
			}

			/// <summary>
			/// Check if hash is supported
			/// </summary>
			/// <param name="hashString">the hash</param>
			/// <returns>is supported?</returns>
			public static bool IsHashSupported(string hashString)
			{
				return hashString.Contains("$MYHASH$V1$");
			}

			/// <summary>
			/// verify a password against a hash
			/// </summary>
			/// <param name="password">the password</param>
			/// <param name="hashedPassword">the hash</param>
			/// <returns>could be verified?</returns>
			public static bool Verify(string password, string hashedPassword)
			{
				//check hash
				if (!IsHashSupported(hashedPassword))
				{
					throw new NotSupportedException("The hashtype is not supported");
				}

				//extract iteration and Base64 string
				var splittedHashString = hashedPassword.Replace("$MYHASH$V1$", "").Split('$');
				var iterations = int.Parse(splittedHashString[0]);
				var base64Hash = splittedHashString[1];

				//get hashbytes
				var hashBytes = Convert.FromBase64String(base64Hash);

				//get salt
				var salt = new byte[SaltSize];
				Array.Copy(hashBytes, 0, salt, 0, SaltSize);

				//create hash with given salt
				var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
				byte[] hash = pbkdf2.GetBytes(HashSize);

				//get result
				for (var i = 0; i < HashSize; i++)
				{
					if (hashBytes[i + SaltSize] != hash[i])
					{
						return false;
					}
				}
				return true;
			}
		}
	}
}
