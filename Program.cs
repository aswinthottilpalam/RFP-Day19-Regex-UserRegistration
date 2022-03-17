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
                Console.WriteLine("Choose an option to execute REGEX program: \n 1. Validate FirstName \n 2. Validate LastName \n 3. Validate Email \n 4. Exit ");
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
                    case 2:
                        Console.WriteLine("Enter Last Name: ");
                        string Name1 = Console.ReadLine();
                        UC2EnterLastName EnterLastName = new UC2EnterLastName();

                        bool value2 = EnterLastName.validateLastName(Name1);
                        if (value2)
                            Console.WriteLine("Valid Name");
                        else
                            Console.WriteLine("Invalid Name");
                        break;
                    case 3:
                        Console.WriteLine("Enter Email: ");
                        string Name2 = Console.ReadLine();
                        UC3EnterEmail EnterEmail = new UC3EnterEmail();

                        bool value3 = EnterEmail.validateEmail(Name2);
                        if (value3)
                            Console.WriteLine("Valid Email");
                        else
                            Console.WriteLine("Invalid Email");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
