using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX_UserRegistration
{
    public class UC2EnterLastName
    {
        public string Regex_Pattern = "^[A-Z a-z]{3,}$";

        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_Pattern);
        }
    }
}
