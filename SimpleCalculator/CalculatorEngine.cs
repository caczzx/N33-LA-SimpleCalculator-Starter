using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

           
            if (argOperation == "+" || argOperation.ToLower() == "add")
            {
                result = argFirstNumber + argSecondNumber;
            }
          
            else if (argOperation == "-" || argOperation.ToLower() == "subtract")
            {
                result = argFirstNumber - argSecondNumber;
            }
          
            else if (argOperation == "*" || argOperation.ToLower() == "multiply")
            {
                result = argFirstNumber * argSecondNumber;
            }
           
            else if (argOperation == "/" || argOperation.ToLower() == "divide")
            {
                if (argSecondNumber != 0)
                {
                    result = argFirstNumber / argSecondNumber;
                }
                else
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
            }
            
            else if (argOperation == "%" || argOperation.ToLower() == "modulus")
            {
                if (argSecondNumber != 0)
                {
                    result = argFirstNumber % argSecondNumber;
                }
                else
                {
                    throw new DivideByZeroException("Cannot perform modulus operation with zero.");
                }
            }

            return result;
        }
    }
}
