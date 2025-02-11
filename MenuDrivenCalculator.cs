using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUsingCSharp
{
    internal class MenuDrivenCalculator
    {
        public static T Add<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a + b;
        }


        public static T Sub<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a - b;
        }


        public static T Mul<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a * b;
        }



        public static T Div<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;

            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return default;
            }
            return a / b;
        }


        public void Calculator()
        {
            while (true)

            {
                Console.WriteLine("\n--- Menu Driven Calculator ---");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");


                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    continue;

                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                Console.Write("Enter first number: ");
                dynamic num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                dynamic num2 = Convert.ToDouble(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Result: {Add(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {Sub(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {Mul(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Result: {Div(num1, num2)}");
                        break;
                }

            }

        }
    }
}
