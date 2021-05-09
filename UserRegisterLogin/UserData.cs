using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisterLogin
{
     class UserData
    {
        public Dictionary<string, User> _userData;

        public UserData()
        {
            _userData = new Dictionary<string, User>();
        }

        public bool AddUser(string userName1, User user)
        {
            if (_userData.ContainsKey(userName1))
            {
                Console.WriteLine("This name Already exists");
                return false;
            }

            _userData.Add(userName1, user);
            Console.WriteLine("congratulations on joining");
            return true;
        }
    }
}
