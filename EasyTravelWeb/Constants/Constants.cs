using System;
using System.Configuration;

namespace EasyTravelWeb.Constants
{
	/// <summary>
	///	 Provides constants for all classes of EasyTravelWeb project.	
	/// </summary>
	internal static class Constants
	{
		/// <summary>
		///		Provides constants for CORSConfig class
		/// </summary>
		internal static class CORSConstants
		{
			/// <summary>
			///		Origin of Cors Policy.
			/// </summary>
			public const string FrontEndUrl = "https://localhost:4200";
		}

		/// <summary>
		///		Provides constants for EmailService class
		/// </summary>
		internal static class EmailServiceConstants
		{
			/// <summary>
			///		Host for SmtpClient.
			/// </summary>
			public const string SmtpClientHost = "smtp.gmail.com";

			/// <summary>
			///		Port for SmtpClient.
			/// </summary>
			public const int SmtpClientPort = 587;

			/// <summary>
			///		Provides credentials for EmailService class.
			/// </summary>
			internal static class Credentials
			{
				/// <summary>
				///		Email that is used for sending requests for confirmation of user email.
				/// </summary>
				public const string Email = "easytravelsystem284@gmail.com";

				/// <summary>
				/// 
				/// </summary>
				public const string Password = ".netlv-284";
			}
		}

		/// <summary>
		///		Provides connection strings.
		/// </summary>
		internal static class ConnectionStrings
		{
			public static string DatabaseConnectionString = ConfigurationManager
				.ConnectionStrings["EasyTravelConnectionString"].ConnectionString;
		}

		/// <summary>
		///		Provides constants for AccountController class.
		/// </summary>
		internal static class AccountControllerConstants
		{
			/// <summary>
			///		URL where user is redirected after email confirmation.
			/// </summary>
			public const string UrlForRedirectAfterEmailConfirmation = "https://localhost:4200/main";

			/// <summary>
			///		Name of local login provider.
			/// </summary>
			public const string LocalLoginProvider = "Local";

			/// <summary>
			///		Number of bits per byte.
			/// </summary>
			public const int BitsPerByte = 8;
		}

		/// <summary>
		///		Provides constants for SearchController class.
		/// </summary>
		internal static class SearchControllerConstants
		{
			/// <summary>
			///		Optimal number of cities or places to show in search suggestions.
			/// </summary>
			public const int NumberOfSearchEntitiesToShow = 4;
		}

		/// <summary>
		///		Provides constants for Startup class.
		/// </summary>
		internal static class StartupConstants
		{
			/// <summary>
			///		Token endpoint path
			/// </summary>
			public const string TokenEndpointPath = "/Token";

			/// <summary>
			///		Authorize endpoint path
			/// </summary>
			public const string AuthorizeEndpointPath = "/api/Account/ExternalLogin";
		}

		/// <summary>
		///		Provides constants for Configuration class.
		/// </summary>
		internal static class ConfigurationConstants
		{
			/// <summary>
			///		String used to distinguish migrations.
			/// </summary>
			public const string ContextKey = "EasyTravelWeb.Models.ApplicationDbContext";
		}

		/// <summary>
		///		Provides constants for Logger class.
		/// </summary>
		internal static class LoggerConstants
		{
			/// <summary>
			///		The path to the file in which exceptions are logged.
			/// </summary>
			public static string PathForFileStream = $@"C:\Users\{Environment.UserName}\EasyTravelLog.txt";
		}

		/// <summary>
		///		Provides constants for data validation.
		/// </summary>
		internal static class DataValidationConstants
		{
			/// <summary>
			///     Minimum amount of password characters.
			/// </summary>
			public const int MinimumPasswordLength = 8;

			/// <summary>
			///     Pattern that must be met by an email. 
			/// </summary>
			/// <example>some@domain.com</example>
			public const string EmailPattern = @"[a-zA-Z0-9_\.\+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-\.]+";

			/// <summary>
			///     Pattern that must be met by a password.
			/// </summary>
			/// <example>Aa1111!@</example>
			public const string PasswordPattern = @"((?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%!]).{8,20})$";


			/// <summary>
			///     Pattern that must be met by first name or last name.
			/// </summary>
			/// <example>Petro</example>
			public const string NamePattern = @"^[а-яА-ЯёЁa-zA-Zʼ'ї Ї і І є Є-]{2,40}$";
		}

	    internal static class BlaBlaCarResponseConstants
	    {
	        public const string URL = "https://public-api.blablacar.com/api/v2/trips";
	    }
	}
}