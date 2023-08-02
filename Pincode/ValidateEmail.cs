using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pincode
{
    public class ValidateEmail
    {
        string UC1_Regex = "^[a-z]{0,}$";
        string UC2_Regex = "^[@]{1}[a-z]{0,}$";
        string UC3_Regex = "^[.]{1}[a-z]{2}$";
        string UC4_Regex_Optional = "^[a-z]+[._+-]{0,1}[a-z]{0,}$";
        string actualRegex = "^[a-z]+[._+-]{0,1}[a-z]+[@]{1}[a-z]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2}){0,1}$";

        public void UC1_Validate(string input)
        {
            bool result = Regex.IsMatch(input, UC1_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void UC2_Validate(string input)
        {
            bool result = Regex.IsMatch(input, UC2_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void UC3_Validate(string input)
        {
            bool result = Regex.IsMatch(input, UC3_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void UC4_Validate(string input)
        {
            bool result = Regex.IsMatch(input, UC4_Regex_Optional);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void UC5_Validate(string input)
        {
            bool result = Regex.IsMatch(input, actualRegex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
    }
}
