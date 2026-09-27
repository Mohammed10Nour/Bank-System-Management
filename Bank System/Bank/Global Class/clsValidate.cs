using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank
{
    public class clsValidate
    {
        public static bool ValidateEmail(string email)
        {
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            var rgx = new Regex(pattern);
           return rgx.IsMatch(email);
        }
        public static bool ValidatePhone(string phone)
        {
             var pattern = @"^[0-9]+$";
             var rgx = new Regex(pattern);
            return rgx.IsMatch(phone);
        }
    }
}
