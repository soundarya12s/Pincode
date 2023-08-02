﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pincode
{
    public class ValidatePincode
    {
        string uc1_Regex = "^[0-9]{6}$";
        string uc4_Regex = "^[0-9]{3}[ ]{0,1}[0-9]{3}$";
        public void UC1_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void UC2_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void UC3_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc1_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
        public void UC4_Validate(string input)
        {
            bool result = Regex.IsMatch(input, uc4_Regex);
            if (result)
                Console.WriteLine("Validation Successful");
            else
                Console.WriteLine("Validation Unsuccessful");
        }
    }
}