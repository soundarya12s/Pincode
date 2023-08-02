using System;

namespace Pincode
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidatePincode validatePincode = new ValidatePincode();
            validatePincode.UC1_Validate("400088");
            validatePincode.UC2_Validate("A400088");
            validatePincode.UC3_Validate("400088A");
        }
    }
}