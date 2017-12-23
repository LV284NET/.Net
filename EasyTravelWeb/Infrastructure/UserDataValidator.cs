using System;
using System.Collections.Generic;
using System.Net.Mail;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Infrastructure
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
            if (this.EmailIsValid(user.Email) &
                this.PasswordIsValid(user.Password) &
                this.FirstNameIsValid(user.FirstName) &
                this.LastNameIsValid(user.LastName))
                return true;

            return false;
        }

        /// <summary>
        ///     Checks if the user email is valid
        /// </summary>
        /// <param name="userEmail">User's email</param>
        /// <returns>bool</returns>
        private bool EmailIsValid(string userEmail)
        {
            if (string.IsNullOrEmpty(userEmail))
            {
                this.validationRegister.Add("User email is required!");

                return false;
            }

            try
            {
                var email = new MailAddress(userEmail);
            }
            catch (Exception ex)
            {
                this.logger.LogExceptionAsync(ex);

                this.validationRegister.Add("Invalid email format");

                return false;
            }

            //try
            //{
            //    userEmail = Regex.Replace(userEmail, @"(@)(.+)$", this.DomainMapper,
            //        RegexOptions.None, TimeSpan.FromMilliseconds(200));
            //}
            //catch (RegexMatchTimeoutException)
            //{
            //    return false;
            //}

            //try
            //{
            //    if (Regex.IsMatch(userEmail,
            //        @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            //        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
            //        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            //    {
            //        this.validationRegister.Add("Invalid email format");

            //        return false;
            //    }
            //}

            //catch (RegexMatchTimeoutException ex)
            //{
            //    this.logger.LogAsync(ex);

            //    return false;
            //}

            return true;
        }

        /// <summary>
        ///     Checks if the user password is valid
        /// </summary>
        /// <param name="userPassword">User's password</param>
        /// <returns>bool</returns>
        private bool PasswordIsValid(string userPassword)
        {
            if (userPassword.Length >= 8) //need imrovement!
                return true;

            return false;
        }

        /// <summary>
        ///     Checks if the user first name is valid
        /// </summary>
        /// <param name="userFirstName">User's first name</param>
        /// <returns>bool</returns>
        private bool FirstNameIsValid(string userFirstName)
        {
            return true; //need imrovement!
        }

        /// <summary>
        ///     Checks if the user last name is valid
        /// </summary>
        /// <param name="userLastName">User's second name</param>
        /// <returns>bool</returns>
        private bool LastNameIsValid(string userLastName)
        {
            return true; //need imrovement!
        }

        //private string DomainMapper(Match match)
        //{
        //    // IdnMapping class with default property values.
        //    IdnMapping idn = new IdnMapping();

        //    string domainName = match.Groups[2].Value;
        //    try
        //    {
        //        domainName = idn.GetAscii(domainName);
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        this.logger.LogAsync(ex);
        //    }
        //    return match.Groups[1].Value + domainName;
        //}

        #endregion
    }
}