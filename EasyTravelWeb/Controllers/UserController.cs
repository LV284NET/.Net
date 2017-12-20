using EasyTravelWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyTravelWeb.Repositories;

namespace EasyTravelWeb.Controllers
{
    public class UserController : ApiController
    {
        private UserRepository userRepository =new UserRepository();

        [HttpPost]
        public User GetUser([FromBody] User myUser)
        {
            return userRepository.GetUser(myUser.Email, myUser.Password);
        }
    }
}
