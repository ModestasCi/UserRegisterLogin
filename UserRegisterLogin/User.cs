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
        public DateTime UserBirhdayDate { get; set; }
        public User(string userName, string userEmail, string userPassword, DateTime userBirthdayDate)

        {
            UserName = userName;
            UserEmail = userEmail;
            UserPassword = userPassword;
            UserBirhdayDate = userBirthdayDate;
        }
        public User(string userName, string userEmail, string userPassword)
        {
        }

        public User()
        {
        }

        public Dictionary<string, User> GetUsers()
        {
            var users = new Dictionary<string, User>();
            var theUser = new User("swyturys", "swyturys@gmail.com", "slaptazodis123");
            users.Add("UserName1", theUser);
            return users;
        }
    }
}
