﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTravelWeb.Models
{
    public class User
    {
        public User()
        {
        }

        public User(int id, string email, string firstName, string lastName)
        {
            this.UserId = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }

}
