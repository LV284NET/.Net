using System;
using EasyTravelWeb.Infrastructure.Validators;
using EasyTravelWeb.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EasyTravelTest.ValidatorsTest
{
	[TestClass]
	public class RegisterBindingModelValidatorTest
	{
		[TestMethod]
		public void GetValidationTest()
		{
			RegisterBindingModelValidator validator = new RegisterBindingModelValidator();

			RegisterBindingModel model = new RegisterBindingModel()
			{
				Email = "x@x.xx",
				Password = "Aa1111!@",
				ConfirmPassword = "Aa1111!@",
				FirstName = "Taras",
				LastName = "Pavliuk"
			};

			Assert.AreEqual("IsValid", validator.GetValidationData(model)[0]);
		}

		[TestMethod]
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
