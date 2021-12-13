using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC6Uppercasepswrd
    {
        public static string Regex_pswrd = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public bool validateuppercase(string pswrd)
        {
            return Regex.IsMatch(pswrd, Regex_pswrd);
        }
    }
}
