using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EasyTravelWeb.Infrastructure.Validators
{
	/// <summary>
	///		Validates user's name
	/// </summary>
	internal class NameValidator : IValidator<string>
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
		///     Initializes instance of the NameValidator class.
		/// </summary>
		public NameValidator()
		{
			this.validationRegister = new List<string>();
			this.logger = Logger.GetInstance();
		}

		#endregion

		#region Public Methods

		/// <summary>
		///		Gets data about validation process of User's name.
		///     Useful in cases of necessary to watch problems concerning the validation process.
		/// </summary>
		/// <param name="name">User's name</param>
		/// <returns>List of information messages about validation process.</returns>
		public List<string> GetValidationData(string name)
		{
			if (this.IsValid(name))
			{
				this.validationRegister.Add("Name is valid");

				return this.validationRegister;
			}

			return this.validationRegister;
		}

		/// <summary>
		///		Checks if user's name is valid.
		/// </summary>
		/// <param name="name">User's name.</param>
		/// <returns>True if user's name is valid, otherwise - false.</returns>
		public bool IsValid(string name)
		{
			if (this.nameIsValid(name))
			{
				return true;
			}

			return false;
		}

		#endregion

		#region Private Methods

		/// <summary>
		///     Checks if a name is valid.
		/// </summary>
		/// <param name="firstName">First name</param>
		/// <returns>True if a name is valid, otherwise - false.</returns>
		private bool nameIsValid(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				this.validationRegister
					.Add("Name can't be null or empty!");

				return false;
			}

			if (this.isNameMetPatternRequirements(name))
			{
				return true;
			}

			this.validationRegister
				.Add("You can not use numbers and symbols for name, except \"-\"");

			return false;
		}

		/// <summary>
		///     Checks if a name is met pattern requirements.
		/// </summary>
		/// <param name="name">User's name</param>
		/// <returns>True if a name is met pattern requirements, otherwise - false.</returns>
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
				this.logger.AsyncLogException(ex);

				return false;
			}

			return false;
		}

		#endregion
	}
}