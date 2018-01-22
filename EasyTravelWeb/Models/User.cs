﻿using System;

namespace EasyTravelWeb.Models
{
    public class User
    {
        public User()
        {
        }

        public User(int id, string email, string firstName, string lastName, string password)
        {
            this.UserId = id;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
        }

        public int UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }
    }

}
