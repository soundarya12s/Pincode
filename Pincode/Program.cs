using System;

namespace Pincode
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the option to execute\n 1.Validate Pincode\n 2.Validate Email\n 3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ValidatePincode validatePincode = new ValidatePincode();
                        validatePincode.UC1_Validate("400088");
                        validatePincode.UC2_Validate("A400088");
                        validatePincode.UC3_Validate("400088A");
                        validatePincode.UC4_Validate("400 088");
                        break;
                    case 2:
                        ValidateEmail validateEmail = new ValidateEmail();
                        validateEmail.UC1_Validate("abc");
                        validateEmail.UC2_Validate("@bridgelabz");
                        validateEmail.UC3_Validate(".co");
                        validateEmail.UC4_Validate("abc.xyz");
                        validateEmail.UC5_Validate("abc.xyz@bridgelabz.co.in");
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}