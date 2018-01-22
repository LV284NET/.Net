using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using EasyTravelWeb.Models;

namespace EasyTravelWeb.Infrastructure.Validators
{
    public class NameChangingValidator : IValidator<String>
    {

        #region Private Fields

        private List<string> name;
        private readonly Logger logger;
        private string namePattern = @"^[а-яА-ЯёЁa-zA-Zʼ'є Є]{2,20}$";

        #endregion

        #region Constructor

        public NameChangingValidator()
        {
            this.name = new List<string>();
            this.logger = Logger.GetInstance();
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Gets data about validation process of the instance of the string class.
        ///     Useful in cases of necessary to watch problems concerning the validation process.
        /// </summary>
        /// <param name="model">Instance of the string class</param>
        /// <returns>List of information messages about validation process</returns>
        public virtual List<string> GetValidationData(string model)
        {
            if (this.IsValid(model))
            {
                this.name.Add("IsValid");

                return this.name;
            }

            return this.name;
        }

        /// <summary>
        ///     Checks if data of the instance of the RegisterBindingModel class is valid
        /// </summary>
        /// <param name="model">Instance of the RegisterBindingModel class</param>
        /// <returns>bool</returns>
        public bool IsValid(string model)
        {
            if (NameIsValid(model))
            {
                return true;
            }

            return false;
        }

        #endregion

        #region Private Methods      

        /// <summary>
        ///     Checks if the first name is valid
        /// </summary>
        /// <param name="name">First or Last name</param>
        /// <returns>bool</returns>
        private bool NameIsValid(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                this.name
                    .Add("First name is required!");

                return false;
            }

            if (this.isNameMetPatternRequirements(name))
            {
                return true;
            }

            this.name
                .Add("You can not use numbers and symbols for first name");

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