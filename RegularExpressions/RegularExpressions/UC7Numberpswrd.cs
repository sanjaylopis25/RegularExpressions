using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC7Numberpswrd
    {
        public static string Regex_pswrd = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        public bool validatenumber(string pswrd)
        {
            return Regex.IsMatch(pswrd, Regex_pswrd);
        }
    }
}
