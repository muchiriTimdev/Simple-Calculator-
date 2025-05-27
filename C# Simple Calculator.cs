using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = Add(num1, num2);
                        break;
                    case "-":
                        result = Subtract(num1, num2);
                        break;
                    case "*":
                        result = Multiply(num1, num2);
                        break;
                    case "/":
                        if (num2 != 0)
                            result = Divide(num1, num2);
                        else
                            Console.WriteLine("Error: Division by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to calculate again? (y/n): ");
                keepRunning = Console.ReadLine().ToLower() == "y";
            }

            Console.WriteLine("Goodbye!");
        }

        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => a / b;
    }
}
