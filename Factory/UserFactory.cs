using DJXYong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJXYong.Factory
{
    public class UserFactory
    {
        public static User CreateNewUser(string email, string username, string password, string role)
        {
            User newUser = new User();
            newUser.UserEmail = email;
            newUser.Username = username;
            newUser.UserPassword = password;
            newUser.UserRole = role;
            return newUser;
        }
    }
}