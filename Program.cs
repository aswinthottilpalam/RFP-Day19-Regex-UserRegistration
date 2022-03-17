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
                Console.WriteLine("Choose an option to execute REGEX program: \n 1. Validate FirstName \n 2. Validate LastName \n 3. Validate Email \n 4. Validate Phone Number \n 5. Validate Password rule1 \n 6. Validate Password rule-2 \n 7. Validate Password rule-3 \n 8. Exit ");
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
                        Console.WriteLine("Enter Phone Number (add +91 before your No): ");
                        string Name3 = Console.ReadLine();
                        UC4EneterPhoneNumber EneterPhoneNumber = new UC4EneterPhoneNumber();

                        bool value4 = EneterPhoneNumber.validatePhoneNumber(Name3);
                        if (value4)
                            Console.WriteLine("Valid Phone number");
                        else
                            Console.WriteLine("Invalid Phone Number");
                        break;
                    case 5:
                        Console.WriteLine("Enter Password: ");
                        string Name4 = Console.ReadLine();
                        UC5PredefinedPassword PredefinedPassword = new UC5PredefinedPassword();

                        bool value5 = PredefinedPassword.validatePassword(Name4);
                        if (value5)
                            Console.WriteLine("Valid Password");
                        else
                            Console.WriteLine("Invalid Password");
                            Console.WriteLine("(Password must contain 8 charectors)");
                        break;
                    case 6:
                        Console.WriteLine("Enter Password: ");
                        string Name5 = Console.ReadLine();
                        UC6PasswordRule2 PasswordRule2 = new UC6PasswordRule2();

                        bool value6 = PasswordRule2.validatePassword(Name5);
                        if (value6)
                            Console.WriteLine("Valid Password");
                        else
                            Console.WriteLine("Invalid Password");
                        break;
                    case 7:
                        Console.WriteLine("Enter Password: ");
                        string Name6 = Console.ReadLine();
                        UC7PasswordRule3 PasswordRule3 = new UC7PasswordRule3();

                        bool value7 = PasswordRule3.validatePassword(Name6);
                        if (value7)
                            Console.WriteLine("Valid Password");
                        else
                            Console.WriteLine("Invalid Password");
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
