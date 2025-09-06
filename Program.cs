//Code by: Yuri Alfrance G. Egipto BSIT 4-2

using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Egipto Simple Calculator ===");
            Console.WriteLine();

            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);

            Console.WriteLine();
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("+ for Addition");
            Console.WriteLine("- for Subtraction");
            Console.WriteLine("* for Multiplication");
            Console.WriteLine("/ for Division");
            Console.Write("Enter your choice (+, -, *, /): ");
            
            string operation = Console.ReadLine();

            Console.WriteLine();
            switch (operation)
            {
                case "+":
                    int addResult = number1 + number2;
                    Console.WriteLine($"Result: {number1} + {number2} = {addResult}");
                    break;
                
                case "-":
                    int subtractResult = number1 - number2;
                    Console.WriteLine($"Result: {number1} - {number2} = {subtractResult}");
                    break;
                
                case "*":
                    int multiplyResult = number1 * number2;
                    Console.WriteLine($"Result: {number1} * {number2} = {multiplyResult}");
                    break;
                
                case "/":
                    if (number2 != 0)
                    {
                        double divideResult = (double)number1 / number2;
                        Console.WriteLine($"Result: {number1} / {number2} = {divideResult}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero!");
                    }
                    break;
                
                default:
                    Console.WriteLine("Error: Invalid operation! Please use +, -, *, or /");
                    break;
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}