using EasyTravelWeb.Repositories;
using System.Web.Http;
using System.Collections.Generic;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using System;
using EasyTravelWeb.Infrastructure.Validators;

namespace EasyTravelWeb.Controllers
{
    public class ProfileController : ApiController
    {
        #region Private Fields

        /// <summary>
        /// Instance of UserRepository, using methods to do actions with database
        /// </summary>
        private readonly UserRepository userRepository = new UserRepository();

        /// <summary>
        /// Instance for stroring exceptions in file
        /// </summary>
        private readonly Logger logger = Logger.GetInstance();

        /// <summary>
        /// Validator fro first and lastn name
        /// </summary>
        private readonly IValidator<string> nameValidator =
            new NameChangingValidator();

        #endregion

        #region Constructors

        public ProfileController() { }

        public ProfileController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        #endregion

        #region Public Controllers

        /// <summary>
        /// Method for getting User from Db
        /// </summary>
        /// <param name="id">id of current user</param>
        /// <returns>First, last, email of user</returns>
        [HttpGet]
        [Route("api/Profile/GetUserInfo")]
        public IHttpActionResult GetUser(int id)
        {
            User user;
            try
            {
                user = this.userRepository.GetUser(id);

            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);

                return this.NotFound();
            }
            return Ok(user);
        }

        /// <summary>
        /// Method for changing first name of a user
        /// </summary>
        /// <param name="id">Id of current user</param>
        /// <param name="firstName">First name which will be updated in database</param>
        /// <returns>result of chaning (Bad or Ok)</returns>
        [HttpPost]
        [Route("api/Profile/ChangeFirstName")]
        public IHttpActionResult ChangeFirstName(int id, string firstName)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (this.nameValidator.IsValid(firstName))
            {
                try
                {
                    this.userRepository.ChangeFirstName(id, firstName);
                }
                catch (Exception ex)
                {
                    this.logger.LogException(ex);

                    return this.BadRequest();
                }
            }

            return this.Ok();
        }

        /// <summary>
        /// Method for changing first name of a user
        /// </summary>
        /// <param name="id">Id of current user</param>
        /// <param name="lastName">Last name which will be updated in database</param>
        /// <returns>result of chaning (Bad or Ok)</returns>
        [HttpPost]
        [Route("api/Profile/ChangeLastName")]
        public IHttpActionResult ChangeLastName(int id, string lastName)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (this.nameValidator.IsValid(lastName))
            {
                try
                {
                    this.userRepository.ChangeLastName(id, lastName);
                }
                catch (Exception ex)
                {
                    this.logger.LogException(ex);

                    return this.BadRequest();
                }
            }

            return this.Ok();
        }

        #endregion
    }
}
