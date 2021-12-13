using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC4MobileNumber
    {
        public static string Regex_number = "^[0-9]{2}[ ][0-9]{10}$";
        public bool validateMobileNumber(string mobilenumber)
        {
            return Regex.IsMatch(mobilenumber, Regex_number);
        }
    }
}
