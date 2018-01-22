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
        private readonly UserRepository userRepository = new UserRepository();
        private readonly Logger logger = Logger.GetInstance();
        private readonly IValidator<string> nameValidator =
            new NameChangingValidator();

        public ProfileController() { }

        public ProfileController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

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
    }
}
