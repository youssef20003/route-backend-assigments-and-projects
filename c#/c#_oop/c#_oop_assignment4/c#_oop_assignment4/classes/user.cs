using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_assignment4.classes
{
    internal class user
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public user(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
