using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX_UserRegistration
{
    public class UC4EneterPhoneNumber
    {
        public string Regex_Pattern = "^[/+]{1}[9]{1}[1]{1}[6-9]{1}[0-9]{9}$";
        public bool validatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_Pattern);
        }
    }
}
