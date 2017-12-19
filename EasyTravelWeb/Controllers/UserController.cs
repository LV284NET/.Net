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
        IList<User> users = new List<User>()
        {
            new User()
            {
                UserId=1, Email="user1@gmail.com", FirstName="Jhon", LastName="Smith", Password="1111"
            },

            new User()
            {
                UserId=2, Email="user2@gmail.com", FirstName="Poll", LastName="Mithel", Password="1111"
            },

            new User()
            {
                UserId=3, Email="user3@gmail.com", FirstName="Rachel", LastName="Green", Password="1111"
            },

            new User()
            {
                UserId=4, Email="user4@gmail.com", FirstName="Sarah", LastName="Bernar", Password="1111"
            },
        };

        [HttpGet]
        public IList<User> GetAllUsers()
        {
            //Return list of all users  
            return this.users;
        }

        public User GetUserDetails(int id)
        {
            //Return a single employee detail  
            var users = this.users.FirstOrDefault(e => e.UserId == id);
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
            return users?.First(row =>
                    row.Email == myUser.Email && row.Password == myUser.Password);
        }
    }
}
