using System;
using System.Collections.Generic;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class UserController : ApiController
    {
        #region Private Fields

        /// <summary>
        /// 
        /// </summary>
        private readonly UserRepository userRepository = new UserRepository();

        /// <summary>
        /// 
        /// </summary>
        private readonly Logger logger = Logger.GetInstance();

        /// <summary>
        /// 
        /// </summary>
        private readonly IValidator<User> userDataValidator = new UserDataValidator();

        /// <summary>
        /// 
        /// </summary>
        private List<string> validationInfo;

        #endregion

        #region API Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [Route("api/user/GetUser")]
        [HttpPost]
        public IHttpActionResult GetUser([FromBody] User user)
        {
            User requiredUser;

            try
            {
                requiredUser = this.userRepository.GetUser(user.Email, user.Password);
            }
            catch (Exception ex)
            {
                this.logger.LogExceptionAsync(ex);

                return this.NotFound();//Status Code: 404
            }

            return this.Ok(requiredUser);//Status Code: 200
        }

        /// <summary>
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [Route("api/user/AddUser")]
        [HttpPost]
        public IHttpActionResult AddUser([FromBody] User user)
        {
            if (this.userDataIsValid(user))
            {
                Guid userGuid = this.userRepository.AddUser(user);

                if (userGuid != Guid.Empty)
                {
                    return this.Created("New user added", userGuid);//Status Code: 201
                }

                return this.BadRequest();//Status Code: 400
            }

            this.logger.LogMessageAsync("User isn't added due to invalid inputted data into the form!");

            return this.Ok(this.validationInfo);//Status Code: 200 - User isn't added!
        }

        #endregion

        #region Private Methods

        private bool userDataIsValid(User user)
        {
            this.validationInfo = this.userDataValidator.Validate(user);

            if (this.validationInfo[0] == "IsValid")
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}