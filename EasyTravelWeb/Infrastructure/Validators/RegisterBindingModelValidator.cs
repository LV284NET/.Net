using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Infrastructure.Validators
{
	/// <inheritdoc />
	/// <summary>
	///     RegisterBindingModelValidator logic
	/// </summary>
	public class RegisterBindingModelValidator : IValidator<RegisterBindingModel>
	{
		#region Private Fields

		/// <summary>
		///     Validation register.
		/// </summary>
		private readonly List<string> validationRegister;

		/// <summary>
		///     Instance of the Logger class for logging exceptions.
		/// </summary>
		private readonly Logger logger;

		#endregion

		#region Constructor

		/// <summary>
		///     Initializes instance of the RegisterBindingModelValidator class.
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
		/// <param name="model">Instance of the RegisterBindingModel class.</param>
		/// <returns>List of information messages about validation process.</returns>
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
		///     Checks if data of the instance of the RegisterBindingModel class is valid.
		/// </summary>
		/// <param name="model">Instance of the RegisterBindingModel class.</param>
		/// <returns>True if a data of the instance of the RegisterBindingModel class is valid, otherwise - false.</returns>
		public bool IsValid(RegisterBindingModel model)
		{
			if (this.emailIsValid(model.Email) &
			    this.isPasswordValid(model.Password) &
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
		///     Checks if the email is valid.
		/// </summary>
		/// <param name="email">email</param>
		/// <returns>True if the email is valid, otherwise - false.</returns>
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
		///     Checks if the email is met pattern requirements.
		/// </summary>
		/// <param name="email">email</param>
		/// <returns>True if the email is met pattern requirements, otherwise - false.</returns>
		private bool isEmailMetPatternRequirements(string email)
		{
			try
			{
				if (Regex.IsMatch(email, 
					Constants.Constants.DataValidationConstants.EmailPattern,
					RegexOptions.IgnoreCase))
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
		///     Checks if the password is valid.
		/// </summary>
		/// <param name="password">password</param>
		/// <returns>True if the password is valid, otherwise - false.</returns>
		private bool isPasswordValid(string password)
		{
			if (password.Length < 
			    Constants.Constants.DataValidationConstants.MinimumPasswordLength)
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
		///     Checks if the password is met pattern requirements.
		/// </summary>
		/// <param name="password">Password</param>
		/// <returns>True if the password is met pattern requirements, otherwise - false.</returns>
		private bool isPasswordMetPatternRequirements(string password)
		{
			try
			{
				if (Regex.IsMatch(password, 
					Constants.Constants.DataValidationConstants.PasswordPattern,
					RegexOptions.None))
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
		///     Checks if the first name is valid.
		/// </summary>
		/// <param name="firstName">First name</param>
		/// <returns>True if the first name is valid, otherwise - false.</returns>
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
		///     Checks if the last name is valid.
		/// </summary>
		/// <param name="lastName">Last name</param>
		/// <returns>True if the last name is valid, otherwise - false.</returns>
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
		///     Checks if the first name or the last name are met pattern requirements.
		/// </summary>
		/// <param name="name">First name or last name</param>
		/// <returns>True if the first name or the last name are met pattern requirements, otherwise - false.</returns>
		private bool isNameMetPatternRequirements(string name)
		{
			try
			{
				if (Regex.IsMatch(name, 
					Constants.Constants.DataValidationConstants.NamePattern,
					RegexOptions.None))
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