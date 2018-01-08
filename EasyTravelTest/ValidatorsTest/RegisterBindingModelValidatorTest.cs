using EasyTravelWeb.Infrastructure.Validators;
using EasyTravelWeb.Models;
using NUnit.Framework;

namespace EasyTravelTest.ValidatorsTest
{
	/// <summary>
	/// Tests for RegisterBindingModelValidator class
	/// </summary>
	[TestFixture]
	public class RegisterBindingModelValidatorTest
	{
		/// <summary>
		/// Test for GetValidation method
		/// </summary>
		[TestCase]
		public void GetValidationTest()
		{
			RegisterBindingModelValidator validator = new RegisterBindingModelValidator();

			RegisterBindingModel model = new RegisterBindingModel()
			{
				Email = "x@x.xx",
				Password = "Aa1111!@",
				ConfirmPassword = "Aa1111!@",
				FirstName = "Taras",
				LastName = "Taras"
			};

			Assert.AreEqual("IsValid", validator.GetValidationData(model)[0]);
		}

		/// <summary>
		/// Test for IsValid method
		/// </summary>
		[TestCase]
		public void IsValidTest()
		{
			RegisterBindingModelValidator validator = new RegisterBindingModelValidator();

			RegisterBindingModel model = new RegisterBindingModel()
			{
				Email = "x@x.xx",
				Password = "aa1111!@",
				ConfirmPassword = "aa1111!",
				FirstName = "Taras",
				LastName = "Pavliuk"
			};

			Assert.AreEqual(false, validator.IsValid(model));
		}
	}
}
