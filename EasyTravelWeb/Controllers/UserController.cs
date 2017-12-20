using System;
using System.Web.Http;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
	public class UserController : ApiController
	{
		private readonly UserRepository userRepository = new UserRepository();

		//[HttpPost]
		//public User GetUser([FromBody] User myUser)
		//{
		//    return userRepository.GetUser(myUser.Email, myUser.Password);
		//}


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

		//[HttpPost]
		//public IHttpActionResult AddUser([FromBody] User newUser)
		//{
		//	Guid userGuid = userRepository.AddUser(newUser);
			
		//	if (userGuid != Guid.Empty)
		//	{
		//		return Created("New user added", userGuid);
		//	}

		//	return BadRequest();
		//}
	}
}