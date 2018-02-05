using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EasyTravelWeb.Infrastructure.Validators
{
	/// <summary>
	///		Validates user's email
	/// </summary>
	public class EmailValidator : IValidator<string>
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
		///     Initializes instance of the EmailValidator class.
		/// </summary>
		public EmailValidator()
		{
			this.validationRegister = new List<string>();
			this.logger = Logger.GetInstance();
		}

		#endregion

		#region Public Methods

		/// <summary>
		///		Gets data about validation process of User's email.
		///     Useful in cases of necessary to watch problems concerning the validation process.
		/// </summary>
		/// <param name="name">User's email</param>
		/// <returns>List of information messages about validation process.</returns>
		public List<string> GetValidationData(string email)
		{
			if (this.IsValid(email))
			{
				this.validationRegister.Add("Email is valid");

				return this.validationRegister;
			}

			return this.validationRegister;
		}


		/// <summary>
		///     Checks if user's emal is valid.
		/// </summary>
		/// <param name="model">User's email.</param>
		/// <returns>True if user's email is valid, otherwise - false.</returns>
		public bool IsValid(string email)
		{
			if (this.emailIsValid(email))

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
				this.logger.AsyncLogException(ex);

				return false;
			}

			this.validationRegister.Add("Invalid email format. Correct format: some@domain.com.");

			return false;
		}

		#endregion
	}
}