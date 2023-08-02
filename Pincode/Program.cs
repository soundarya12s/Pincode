using System;

namespace Pincode
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidatePincode validatePincode = new ValidatePincode();
            validatePincode.Validate("400088");
        }
    }
}