using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForAuth.Models
{
    public class User
    {
        private static readonly List<User> _users = new List<User>();
        public static List<User> GetUsers()
        {
            _users.Add(new User()
            {
                Username = "admin",
                Password = "nimda",
                UserRoles = new List<string>() { "Admin" }
            });
            _users.Add(new User()
            {
                Username = "normal",
                Password = "normal",
                UserRoles = new List<string>() { "Customer" }
            });
            return _users;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Aadhar { get; set; }
        public string Email { get; set; }
        public List<string> UserRoles { get; set; }
    }
}