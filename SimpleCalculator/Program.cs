using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber;
                while (!double.TryParse(Console.ReadLine(), out firstNumber)){
                    Console.WriteLine("Invalid input. Please try again: ");
                    Console.WriteLine("Valid inputs are numbers.");
                }

                double secondNumber;
                 while (!double.TryParse(Console.ReadLine(), out secondNumber)){
                    Console.WriteLine("Invalid input. Please try again: ");
                    Console.WriteLine("Valid inputs are numbers");
                }

                String operation;
                bool isValid = false;

                while (isValid == false){
                     if (operation.ToLower() != "add" && operation != "+" && operation.ToLower() != "divide" && operation != "/"){
                         Console.WriteLine("Invalid input. Please try again: ");
                         Console.WriteLine("add, +, divide, and / are the only valide inputs.")
                    }    
                    else{
                        isValid = true;
                    }
                }       

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                StringBuilder results = new StringBuilder();
                results.Append("The value {0} {1} the value {2} is equal to {3}.", firstNumber, operation, secondNumber, result);
                
                Console.WriteLine(results.ToString());

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
