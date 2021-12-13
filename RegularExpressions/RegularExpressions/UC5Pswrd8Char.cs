using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC5Pswrd8Char
    {
        public static string Regex_pswrd = "^[A-Za-z0-9]{8,}$";
        public bool validate8charpswrd(string pswrd)
        {
            return Regex.IsMatch(pswrd, Regex_pswrd);
        }
    }
}
