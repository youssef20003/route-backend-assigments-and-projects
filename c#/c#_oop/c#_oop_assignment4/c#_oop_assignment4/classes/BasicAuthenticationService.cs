using c__oop_assignment4.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__oop_assignment4.classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private user[] users = new user[]
   {
        new user("admin", "admin123", "Administrator"),
        new user("john", "john123", "User"),
        new user("sara", "sara456", "Manager")
   };

        public bool AuthenticateUser(string username, string password)
        {
            foreach (user user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            foreach (user user in users)
            {
                if (user.Username == username && user.Role == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
    }

