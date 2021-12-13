using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC2LastName
    {
        public static string Regex_lastname = "^[A-Z][A-Za-z]{2,}[ ][A-Z][A-Za-z]{2,}$";
        public bool validateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, Regex_lastname);
        }
    }
}
