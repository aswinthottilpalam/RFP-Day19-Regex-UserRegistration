using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX_UserRegistration
{
    public class UC1EnterFirstName
    {
        public string Regex_Pattern = "^[A-Z a-z]{3,}$";

        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_Pattern);
        }
    }
}
