using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Infrastructure.Validators
{
	/// <summary>
	///     RegisterBindingModelValidator logic
	/// </summary>
	public class RegisterBindingModelValidator : IValidator<RegisterBindingModel>
	{
		///must be in special class!
		#region Constants

		/// <summary>
		///     Minimum amount of password characters
		/// </summary>
		private const int PasswordLength = 8;

		#endregion

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
		private readonly string emailPattern = @"[a-zA-Z0-9_\.\+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-\.]+";

		/// <summary>
		///     Pattern that must be met by a password (i.e. Aa1111!@)
		/// </summary>
		private string passwordPattern = @"((?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%!]).{8,20})$";


		/// <summary>
		///     Pattern that must be met by first name or last name (i.e. Pavlo)
		/// </summary>
		private string namePattern = @"^[а-яА-ЯёЁa-zA-Zʼ'є Є]{2,20}$";

		#endregion

		#region Constructor

		/// <summary>
		///     Initializes instance of the UserDataValidator class
		/// </summary>
		public RegisterBindingModelValidator()
		{
			this.validationRegister = new List<string>();
			this.logger = Logger.GetInstance();
		}

		#endregion

		#region Public Methods

		/// <summary>
		///     Gets data about validation process of the instance of the RegisterBindingModel class.
		///     Useful in cases of necessary to watch problems concerning the validation process.
		/// </summary>
		/// <param name="model">Instance of the RegisterBindingModel class</param>
		/// <returns>List of information messages about validation process</returns>
		public virtual List<string> GetValidationData(RegisterBindingModel model)
		{
			if (this.IsValid(model))
			{
				this.validationRegister.Add("IsValid");

				return this.validationRegister;
			}

			return this.validationRegister;
		}

		/// <summary>
		///     Checks if data of the instance of the RegisterBindingModel class is valid
		/// </summary>
		/// <param name="model">Instance of the RegisterBindingModel class</param>
		/// <returns>bool</returns>
		public bool IsValid(RegisterBindingModel model)
		{
			if (this.emailIsValid(model.Email) &
			    this.passwordIsValid(model.Password) &
			    this.firstNameIsValid(model.FirstName) &
			    this.lastNameIsValid(model.LastName))
			{
				return true;
			}

			return false;
		}

		#endregion

		#region Private Methods

		/// <summary>
		///     Checks if the email is valid
		/// </summary>
		/// <param name="email">email</param>
		/// <returns>bool</returns>
		private bool emailIsValid(string email)
		{
			if (string.IsNullOrEmpty(email))
			{
				this.validationRegister.Add("Email is required!");

				return false;
			}

			if (this.isEmailMetPatternRequirements(email))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		///     Checks if the email is met pattern requirements
		/// </summary>
		/// <param name="email">email</param>
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

			this.validationRegister.Add("Invalid email format. Correct format: some@domain.com.");

			return false;
		}

		/// <summary>
		///     Checks if the password is valid
		/// </summary>
		/// <param name="password">password</param>
		/// <returns>bool</returns>
		private bool passwordIsValid(string password)
		{
			if (password.Length < PasswordLength)
			{
				this.validationRegister
					.Add("Password length must be equal or greater than 8 chars");

				return false;
			}

			if (this.isPasswordMetPatternRequirements(password))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		///     Checks if the password is met pattern requirements
		/// </summary>
		/// <param name="password">Password</param>
		/// <returns></returns>
		private bool isPasswordMetPatternRequirements(string password)
		{
			try
			{
				if (Regex.IsMatch(password, this.passwordPattern,
					RegexOptions.None, TimeSpan.FromMilliseconds(250)))
				{
					return true;
				}
			}

			catch (RegexMatchTimeoutException ex)
			{
				this.logger.LogException(ex);

				return false;
			}

			this.validationRegister.Add("Password isn't strong enough: " +
			                            "it must have at least one capital letter " +
			                            "and one symbol");

			return false;
		}

		/// <summary>
		///     Checks if the first name is valid
		/// </summary>
		/// <param name="firstName">First name</param>
		/// <returns>bool</returns>
		private bool firstNameIsValid(string firstName)
		{
			if (string.IsNullOrEmpty(firstName))
			{
				this.validationRegister
					.Add("First name is required!");

				return false;
			}

			if (this.isNameMetPatternRequirements(firstName))
			{
				return true;
			}

			this.validationRegister
				.Add("You can not use numbers and symbols for first name");

			return false;
		}

		/// <summary>
		///     Checks if the last name is valid
		/// </summary>
		/// <param name="lastName">Last name</param>
		/// <returns>bool</returns>
		private bool lastNameIsValid(string lastName)
		{
			if (string.IsNullOrEmpty(lastName))
			{
				this.validationRegister
					.Add("Last name is required!");

				return false;
			}

			if (this.isNameMetPatternRequirements(lastName))
			{
				return true;
			}

			this.validationRegister
				.Add("You can not use numbers and symbols for last name");

			return false;
		}

		/// <summary>
		///     Checks if the first name or the last name are met pattern requirements
		/// </summary>
		/// <param name="name">First name or last name</param>
		/// <returns>bool</returns>
		private bool isNameMetPatternRequirements(string name)
		{
			try
			{
				if (Regex.IsMatch(name, this.namePattern,
					RegexOptions.None, TimeSpan.FromMilliseconds(250)))
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

		#endregion
	}
}