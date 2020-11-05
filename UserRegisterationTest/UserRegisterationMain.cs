using System;

namespace UserRegisterationTest
{
    class UserRegisterationMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registeration");
            UserValidator userValidator = new UserValidator();
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(userValidator.ValidateFirstName(firstName));

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine(userValidator.ValidateLastName(lastName));

            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine(userValidator.ValidateEmail(email));

            Console.WriteLine("Enter your mobile number");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine(userValidator.ValidateMobileNumber(mobileNumber));
        }
    }
}
