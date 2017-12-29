using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Infrastructure.Validators;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using Microsoft.AspNet.Identity;

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
        [Authorize]
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
                this.logger.LogException(ex);

                return this.NotFound();//Status Code: 404
            }

            return this.Ok(requiredUser);//Status Code: 200
        }

        //[Route("Register")]
        //public async Task<IHttpActionResult> Register(RegisterBindingModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var user = new ApplicationUser() { UserName = model.Email, Email = model.Email };

        //    IdentityResult result = await UserManager.CreateAsync(user, model.Password);

        //    if (!result.Succeeded)
        //    {
        //        return GetErrorResult(result);
        //    }

        //    return Ok();
        //}
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

            this.logger.LogMessage("User isn't added due to invalid inputted data into the form!");

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