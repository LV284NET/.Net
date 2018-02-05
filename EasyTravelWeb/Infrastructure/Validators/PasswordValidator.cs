using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EasyTravelWeb.Infrastructure.Validators
{
	/// <summary>
	///		Validates user's password
	/// </summary>
	public class PasswordValidator : IValidator<string>
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
		///     Initializes instance of the PasswordValidator class.
		/// </summary>
		public PasswordValidator()
		{
			this.validationRegister = new List<string>();
			this.logger = Logger.GetInstance();
		}

		#endregion

		#region Public Methods

		/// <summary>
		///		Gets data about validation process of User's password.
		///     Useful in cases of necessary to watch problems concerning the validation process.
		/// </summary>
		/// <param name="name">User's password</param>
		/// <returns>List of information messages about validation process.</returns>
		public List<string> GetValidationData(string password)
		{
			if (this.IsValid(password))
			{
				this.validationRegister.Add("Password is valid");

				return this.validationRegister;
			}

			return this.validationRegister;
		}

		/// <summary>
		///		Checks if user's password is valid.
		/// </summary>
		/// <param name="name">User's password.</param>
		/// <returns>True if user's password is valid, otherwise - false.</returns>
		public bool IsValid(string password)
		{
			if (this.isPasswordValid(password))
			{
				return true;
			}

			return false;
		}

		#endregion

		#region Private Methods

		/// <summary>
		///     Checks if the password is valid.
		/// </summary>
		/// <param name="password">User's password</param>
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
		/// <param name="password">User's assword</param>
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
				this.logger.AsyncLogException(ex);

				return false;
			}

			this.validationRegister.Add("Password isn't strong enough: " +
			                            "it must have at least one capital letter " +
			                            "and one symbol");

			return false;
		}

		#endregion
	}
}