using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC3ValidEmail
    {
        public static string Regex_email = "^[A-Za-z]+([.][A-Za-z]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
        public bool validateUserEmail(string useremail)
        {
            return Regex.IsMatch(useremail, Regex_email);
        }
    }
}
