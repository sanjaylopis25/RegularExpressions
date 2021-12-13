using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class UC8SpclChar
    {
        public static string Regex_pswrd = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$£%&]).{8,}$";
        public bool validatesplchar(string pswrd)
        {
            return Regex.IsMatch(pswrd, Regex_pswrd);
        }
    }
}
