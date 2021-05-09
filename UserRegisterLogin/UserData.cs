using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisterLogin
{
    public class UserData
    {
        public static int? GetAgeInYears(DateTime userBirthdayDate)
        {
            if (userBirthdayDate > DateTime.Now)
                return null;
            int years = DateTime.Now.Year - userBirthdayDate.Year;

            if (DateTime.Now.Month < userBirthdayDate.Month ||
               (DateTime.Now.Month == userBirthdayDate.Month &&
                DateTime.Now.Day < userBirthdayDate.Day))
            {
                years--;
            }
            if (years >= 0)
                return years;
            else
                return 0;
        }
        private static bool IsEmailValid(string userEmail)
        {
            if (!userEmail.EndsWith(".com") || !userEmail.Contains("@"))
            {
                return false;
            }

            return true;
        }

        private static void AskToEnterEmail(string userEmail)
        {
            Console.WriteLine("Please enter your email: ");
            userEmail = Console.ReadLine();

            if (!IsEmailValid(userEmail))
            {
                Console.WriteLine("Incorect email");
            }
            else
            {
                Console.WriteLine("emmm???? .");
            }
        }
    }
}
