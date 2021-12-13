using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC9EmailSamples
    {
        public static string Regex_email = "^([A-Za-z0-9]+[.#+_-])*[A-Za-z0-9]+[@][A-Za-z0-9]+[.][A-Za-z]{2,3}([.][A-Za-z]{2,3})?$";
        public bool validateUserEmail(string useremail)
        {
            return Regex.IsMatch(useremail, Regex_email);
        }
    }
}
