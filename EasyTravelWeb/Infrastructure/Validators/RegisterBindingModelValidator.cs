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

		/// <summary>
		///		Instance of the class that implements IValidator interface for name validation.
		/// </summary>
		private IValidator<string> nameValidator;

		/// <summary>
		///		Instance of the class that implements IValidator interface for email validation.
		/// </summary>
		private IValidator<string> emailValidator;

		/// <summary>
		///		Instance of the class that implements IValidator interface for password validation.
		/// </summary>
		private IValidator<string> passwordValidator;

		#endregion

		#region Constructor

		/// <summary>
		///     Initializes instance of the RegisterBindingModelValidator class.
		/// </summary>
		public RegisterBindingModelValidator()
		{
			this.validationRegister = new List<string>();
			this.logger = Logger.GetInstance();
			this.nameValidator = new NameValidator();
			this.emailValidator = new EmailValidator();
			this.passwordValidator = new PasswordValidator();
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
				this.validationRegister.Add("User's info is valid");

				return this.validationRegister;
			}

			this.validationRegister.AddRange(
				this.emailValidator.GetValidationData(model.Email));

			this.validationRegister.AddRange(
				this.passwordValidator.GetValidationData(model.Password));

			this.validationRegister.AddRange(
				this.nameValidator.GetValidationData(model.FirstName));

			this.validationRegister.AddRange(
				this.nameValidator.GetValidationData(model.LastName));

			return this.validationRegister;
		}

		/// <summary>
		///     Checks if data of the instance of the RegisterBindingModel class is valid.
		/// </summary>
		/// <param name="model">Instance of the RegisterBindingModel class.</param>
		/// <returns>True if a data of the instance of the RegisterBindingModel class is valid, otherwise - false.</returns>
		public bool IsValid(RegisterBindingModel model)
		{
			if (this.emailValidator.IsValid(model.Email) &
			    this.passwordValidator.IsValid(model.Password) &
			    this.nameValidator.IsValid(model.FirstName) &
			    this.nameValidator.IsValid(model.LastName))
			{
				return true;
			}

			return false;
		}

		#endregion
	}
}