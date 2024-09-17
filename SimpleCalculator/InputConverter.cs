using System;

namespace SimpleCalculator
{
    public static class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;

            
            bool isValid = double.TryParse(argTextInput, out convertedNumber);

            if (!isValid)
            {
                throw new ArgumentException("Expected a numeric value.");
            }

            return convertedNumber;
        }
    }
}
