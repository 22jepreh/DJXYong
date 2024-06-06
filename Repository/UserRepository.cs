using DJXYong.Factory;
using DJXYong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJXYong.Repository
{
    public class UserRepository
    {
        public static String CreateNewUser(String email, String username, String password, String role)
        {
            DJXYongDatabaseEntities db = new DJXYongDatabaseEntities();
            User newUser = UserFactory.CreateNewUser(email, username, password, role);
            db.Users.Add(newUser);
            db.SaveChanges();
            return "Register Successful";
        }

        public static User LoginUser(String email, String password)
        {
            DJXYongDatabaseEntities db = new DJXYongDatabaseEntities();
            User loginUser = (from x in db.Users where x.UserEmail == email || x.UserPassword == password select x).FirstOrDefault();
            return loginUser;
        }
    }
}