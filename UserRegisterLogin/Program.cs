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

            SelectAction();
            Console.ReadLine();
        }

        public static void SelectAction()
        {
            Console.WriteLine("If you want to 'Login' type 1  . If you are registered, type 2. ");
            string userLoginRegisterInput = Console.ReadLine();
            if (userLoginRegisterInput != "1" && userLoginRegisterInput != "2")
            {
                Console.WriteLine($"{userLoginRegisterInput} is invalid, please type button 1 or 2 to continue");
            }
            if (userLoginRegisterInput.Equals(value: "1"))
            {
                LoginUser(userLoginRegisterInput);
            }
            else if (userLoginRegisterInput.Equals(value: "2"))
            {
                RegisterNewUser(userLoginRegisterInput);
            }
        }

        public static string LoginUser(string userLoginRegisterInput)
        {
            Console.WriteLine("To login, enter your \n User name: \n Password: ");
            return Console.ReadLine();
            //string userName = Console.ReadLine();
        }

        public static bool IsPasswordAvailable(string userPassword)
        {
            if (userPassword.Contains(" "))
            {
                return false;
            }
            return true;
        }

        public static bool IsUserNamelAvailable(string userName1)
        {
            if (!userName1.Contains(" "))
            {
                return false;
            }
            return true;
        }

        private static bool UserLoginRegisterInput(string userLoginRegisterInput)
        {
            if (userLoginRegisterInput != "1" && userLoginRegisterInput != "2")
            {
                return false;
            }
            return true;
        }
        //private static bool IsEmailAvailable(string userEmail)
        //{
        //    if (!userEmail.Contains("@"))
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        public static string RegisterNewUser(string userLoginRegisterInput)
        {
            Console.WriteLine("To register enter your \n User name: \n Email: \n Password: \n Birth date: ");
            User user = new User();
            user.UserName = Console.ReadLine();

            while (true)
            // string userName = Console.ReadLine();
            // if (UserData.UserExists(userName)) blogas?
            //contain
            //if (!userName.Contains(userName))
            {
                if (!IsUserNamelAvailable(user.UserName))
                {
                    Console.WriteLine("User-name is occupied, please try another one.");
                    user.UserName = Console.ReadLine();
                }
                if (!user.UserName.Contains(" "))
                {
                    break;
                }

                user.UserPassword = Console.ReadLine();
                while (true)
                {
                    if (!IsPasswordAvailable(user.UserPassword))
                    {
                        Console.WriteLine("Incorect password. Try once more.");
                        user.UserPassword = Console.ReadLine();
                    }
                    if (!user.UserPassword.Contains(" "))
                    {
                        break;
                    }
                }

                user.UserEmail = Console.ReadLine();
                while (true)
                {
                    if (!IsUserEmailAvailable(user.UserEmail))
                    {
                        Console.WriteLine("Wrong email, please type again");
                        user.UserEmail = Console.ReadLine();
                        if (user.UserEmail.EndsWith("@"))
                        {
                            break;
                        }
                    }
                }

                UserData userData = new UserData();
                userData.AddUser(user.UserName, user);
                return Console.ReadLine();
            }
        }
        private static bool IsUserEmailAvailable(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}
