using System;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;
using System.Web.Http;

namespace EasyTravelWeb.Controllers
{
	public class UserController : ApiController
	{
		private readonly UserRepository userRepository = new UserRepository();

	    [Route("api/user/GetUser")]
        [HttpPost]
		public IHttpActionResult GetUser([FromBody] User user)
		{
			User requiredUser;

			try
			{
				requiredUser = userRepository.GetUser(user.Email, user.Password);
			}
			catch (Exception)
			{
				return Unauthorized();
			}

			return Ok(requiredUser);
		}

	    [Route("api/user/AddUser")]
        [HttpPost]
        public IHttpActionResult AddUser([FromBody] User newUser)
        {
            Guid userGuid = userRepository.AddUser(newUser);

            if (userGuid != Guid.Empty)
            {
                return Created("New user added", userGuid);
            }

            return BadRequest();
        }
    }
}