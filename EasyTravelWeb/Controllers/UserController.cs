using EasyTravelWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyTravelWeb.Controllers
{
    public class UserController : ApiController
    {
        EasyTravelDB db=new EasyTravelDB();
     
        [HttpGet]
        public List<User> GetAllUsers()
        {
            //Return list of all users  
            return this.db.Users.ToList();
        }

        public User GetUserDetails(int id)
        {
            //Return a single employee detail  
            var users = this.db.Users.FirstOrDefault(e => e.idUser == id);
            if (users == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return users;
        }

        public class MyUser
        {
            public string Email { get; set; }
            public string Password { get; set; }


        }

        [HttpPost]
        public User GetUser([FromBody] MyUser myUser)
        {
            return db.Users.ToList()?.First(row =>
                    row.EMail == myUser.Email && row.Password == myUser.Password);
        }
    }
}
