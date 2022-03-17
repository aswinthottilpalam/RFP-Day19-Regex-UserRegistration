using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX_UserRegistration
{
    public class UC3EnterEmail
    {
        public string Regex_Pattern = "^[a-z A-Z 0-9 + _ . -]+@[a-z A-Z 0-9 . -]+$";
        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Pattern);
        }
    }
}
