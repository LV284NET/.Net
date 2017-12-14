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
                UserId=1, Email="user1@gmail.com", FirstName="Jhon", LastName="Smith"
            },

            new User()
            {
                UserId=2, Email="user2@gmail.com", FirstName="Poll", LastName="Mithel"
            },

            new User()
            {
                UserId=3, Email="user3@gmail.com", FirstName="Rachel", LastName="Green"
            },

            new User()
            {
                UserId=4, Email="user4@gmail.com", FirstName="Sarah", LastName="Bernar"
            },
        };

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

    }
}
