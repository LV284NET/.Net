using System;
using System.Web.Http;
using EasyTravelWeb.Models;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
	public class UserController : ApiController
	{
		private readonly UserRepository _userRepository = new UserRepository();

		private Logger _loger = Logger.GetInstance();

		[Route ("api/user/GetUser")]
		[HttpPost]
		public IHttpActionResult GetUser([FromBody] User user)
		{
			User requiredUser;

			try
			{
				requiredUser = _userRepository.GetUser(user.Email, user.Password);
			}
			catch (Exception ex)
			{
				_loger.Log("api/user/GetUser: " + ex.Message);

				return NotFound();
			}

			return Ok(requiredUser);
		}

		[Route("api/user/AddUser")]
		[HttpPost]
		public IHttpActionResult AddUser([FromBody] User newUser)
		{
			Guid userGuid = _userRepository.AddUser(newUser);

			if (userGuid != Guid.Empty)
			{
				return Created("New user added", userGuid);
			}

			return BadRequest();
		}
	}
}