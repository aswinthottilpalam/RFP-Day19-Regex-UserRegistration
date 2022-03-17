using System;

namespace REGEX_UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************REGEX USER REGISTRATION *****************");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("User Registration validate using regular expression");
                Console.WriteLine("Choose an option to execute REGEX program: \n 1. Validate FirstName \n 2. Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter First Name: ");
                        string Name = Console.ReadLine();
                        UC1EnterFirstName EnterFirstName = new UC1EnterFirstName();

                        bool value1 = EnterFirstName.validateFirstName(Name);
                        if (value1)
                            Console.WriteLine("Valid Name");
                        else
                            Console.WriteLine("Invalid Name");
                    break;
                }
            }
        }
    }
}
