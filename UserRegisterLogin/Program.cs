using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisterLogin
{
    //    1. Ask if user wants login or register.
    //2. If register, ask user-name(key), password, email, dateOfBirth Dictionary<string, Person>
    //3. check if such user does not exists, (AddToDictionary(...))
    //   if exists,  print to screen to try new user-name
    //   if not, display message that user registered

    //4.  If login, ask user-name and password, 
    //if correct entered, display success message,
    //if not, ask to enter password again
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> users = new Dictionary<string, string>();
            //users.Add("Modestas", "vardas");
          //naujausias update  var theUser = User.EqualsUserName();



            Console.WriteLine("If you want to 'Login' type 1  . If you are registered, type 2. ");
            string userLoginRegister = Console.ReadLine();
            if (userLoginRegister != "1" && userLoginRegister != "2")
            {
                Console.WriteLine("Bad input, please type button 1 or 2 to continue");
                userLoginRegister = Console.ReadLine();
            }
            if (userLoginRegister.Equals(value: "1"))
            {
                LoginNewUser();
            }
            if (userLoginRegister.Equals(value: "2"))
            {
                RegisterNewUser();
            }

        }
        public static void LoginNewUser()
        {
            Console.WriteLine("To login, enter your user - name: ");
            string userName = Console.ReadLine();
        }
        public static void RegisterNewUser()
        {
            Console.WriteLine("To register enter your user - name: ");
            string userName = Console.ReadLine();

            // if (UserData.UserExists(userName)) blogas?
            //contain
            if (!userName.Contains(userName))
            {
                Console.WriteLine("User-name is occupied, please try another one.");
            }

            Console.ReadLine();
        }



    }
}
