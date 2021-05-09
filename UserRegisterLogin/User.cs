using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisterLogin
{
    public class User
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public static int UserBirhdayDate { get; set; }
        public User(string userName, string userEmail, string userPassword, int userBirthdayDate)
        {
            UserName = userName;
            UserEmail = userEmail;
            UserPassword = userPassword;
            UserBirhdayDate = userBirthdayDate;
        }
        public Dictionary<string, User> GetUsers()
        {
            var users = new Dictionary<string, User>();
            var theUser = new User(UserName, UserEmail, UserPassword, UserBirhdayDate);
            users.Add(UserName, theUser);

            return users;
        }


    }
}
