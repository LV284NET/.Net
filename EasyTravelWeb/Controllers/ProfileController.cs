using EasyTravelWeb.Repositories;
using System.Web.Http;
using System.Collections.Generic;
using EasyTravelWeb.Infrastructure;
using EasyTravelWeb.Models;
using System;

namespace EasyTravelWeb.Controllers
{
    public class ProfileController : ApiController
    {
        private readonly UserRepository userRepository = new UserRepository();
        private readonly Logger logger = Logger.GetInstance();

        public ProfileController() { }

        public ProfileController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        [Route("api/Profile/GetUserInfo")]
        public IHttpActionResult GetUser(string email)
        {
            User user;
            try
            {
                user = this.userRepository.GetUser(email);

            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);

                return this.NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        [Route("api/Profile/ChangeFirstName")]
        public IHttpActionResult ChangeFirstName(string email, string firstName, string lastName)
        {
            try
            {
                this.userRepository.ChangeFirstName(email, firstName);
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);

                return this.BadRequest();
            }

            return this.Ok();
        }

        [HttpPost]
        [Route("api/Profile/ChangeLastName")]
        public IHttpActionResult ChangeLastName(string email, string lastName)
        {
            try
            {
                this.userRepository.ChangeLastName(email, lastName);
            }
            catch (Exception ex)
            {
                this.logger.LogException(ex);

                return this.BadRequest();
            }

            return this.Ok();
        }
    }
}
