using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Infrastructure.Validators
{
	/// <summary>
	///     UserDataValidator logic
	/// </summary>
	public class UserDataValidator : IValidator<User>
	{
		#region Private Fields

		/// <summary>
		///     Validation register
		/// </summary>
		private readonly List<string> validationRegister;

		/// <summary>
		///     Instance of the Logger class for logging exceptions
		/// </summary>
		private readonly Logger logger;

		/// <summary>
		///     Pattern that must be met by an email (i.e. some@domain.com)
		/// </summary>
		private readonly string emailPattern = @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

		#endregion
		
		#region Constructor

		/// <summary>
		///     Initializes instance of the UserDataValidator class
		/// </summary>
		public UserDataValidator()
		{
			this.validationRegister = new List<string>();
			this.logger = Logger.GetInstance();
		}

		#endregion

		#region Public Methods

		/// <summary>
		///     Vaidates user's data
		/// </summary>
		/// <param name="user">User whose data must be validated</param>
		/// <returns>List of information messages about validation status</returns>
		public List<string> Validate(User user)
		{
			if (this.userDataIsValid(user))
			{
				this.validationRegister.Add("IsValid");

				return this.validationRegister;
			}

			return this.validationRegister;
		}

		#endregion
		
		#region Private Methods

		/// <summary>
		///     Checks if the user data is valid
		/// </summary>
		/// <param name="user">User whose data must be validated</param>
		/// <returns>bool</returns>
		private bool userDataIsValid(User user)
		{
			if (this.emailIsValid(user.Email) &
			    this.passwordIsValid(user.Password) &
			    this.firstNameIsValid(user.FirstName) &
			    this.lastNameIsValid(user.LastName))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		///     Checks if the user email is valid
		/// </summary>
		/// <param name="userEmail">User's email</param>
		/// <returns>bool</returns>
		private bool emailIsValid(string userEmail)
		{
			if (string.IsNullOrEmpty(userEmail))
			{
				this.validationRegister.Add("User email is required!");

				return false;
			}

			if (this.isEmailMetPatternRequirements(userEmail))
			{
				return true;
			}

			this.validationRegister.Add("Invalid email format");

			return false;
		}

		/// <summary>
		///     Checks if the user's email is met pattern requirements
		/// </summary>
		/// <param name="email">User's email</param>
		/// <returns>bool</returns>
		private bool isEmailMetPatternRequirements(string email)
		{
			try
			{
				if (Regex.IsMatch(email, this.emailPattern,
					RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
				{
					return true;
				}
			}

			catch (RegexMatchTimeoutException ex)
			{
				this.logger.LogException(ex);

				return false;
			}

			return false;
		}

		/// <summary>
		///     Checks if the user password is valid
		/// </summary>
		/// <param name="userPassword">User's password</param>
		/// <returns>bool</returns>
		private bool passwordIsValid(string userPassword)
		{
			if (userPassword.Length >= 8)
			{
				return true;
			}

			this.validationRegister.Add("Password length must be equal or greater than 8 chars");

			return false;
		}

		/// <summary>
		///     Checks if the user first name is valid
		/// </summary>
		/// <param name="userFirstName">User's first name</param>
		/// <returns>bool</returns>
		private bool firstNameIsValid(string userFirstName)
		{
			if (string.IsNullOrEmpty(userFirstName))
			{
				this.validationRegister.Add("User first name is required!");

				return false;
			}

			return true;
		}

		/// <summary>
		///     Checks if the user last name is valid
		/// </summary>
		/// <param name="userLastName">User's second name</param>
		/// <returns>bool</returns>
		private bool lastNameIsValid(string userLastName)
		{
			if (string.IsNullOrEmpty(userLastName))
			{
				this.validationRegister.Add("User last name is required!");

				return false;
			}

			return true;
		}

		#endregion
	}
}