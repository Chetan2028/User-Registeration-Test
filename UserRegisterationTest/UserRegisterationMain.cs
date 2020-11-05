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
        }
    }
}
