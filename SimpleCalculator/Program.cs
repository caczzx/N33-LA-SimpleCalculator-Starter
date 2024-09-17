using System;
using System.Text;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Enter the first number:");
                double firstNumber;
                while (!double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Invalid input. Please try again: ");
                    Console.WriteLine("Valid inputs are numbers.");
                }

                Console.WriteLine("Enter the second number:");
                double secondNumber;
                while (!double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Invalid input. Please try again: ");
                    Console.WriteLine("Valid inputs are numbers.");
                }

                Console.WriteLine("Enter the operation (add, +, divide, /, subtract, -, multiply, *, modulus, %):");

               
                string operation = string.Empty;
                bool isValid = false;

                while (!isValid)
                {
                    operation = Console.ReadLine(); 

                    if (operation.ToLower() != "add" && operation != "+" &&
                        operation.ToLower() != "divide" && operation != "/" &&
                        operation.ToLower() != "subtract" && operation != "-" &&
                        operation.ToLower() != "multiply" && operation != "*" &&
                        operation.ToLower() != "modulus" && operation != "%")
                    {
                        Console.WriteLine("Invalid input. Please try again: ");
                        Console.WriteLine("Valid inputs are add, +, divide, /, subtract, -, multiply, *, modulus, %.");
                    }
                    else
                    {
                        isValid = true;
                    }
                }

               
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

              
                string results = string.Format("The value {0} {1} the value {2} is equal to {3}.", firstNumber, operation, secondNumber, result);

                Console.WriteLine(results);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
