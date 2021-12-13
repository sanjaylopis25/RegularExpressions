using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC1FirstName
    {

        public static string Regex_firstname = "^[A-Z][A-Za-z]{2,}$";
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, Regex_firstname);
        }
    }
}
