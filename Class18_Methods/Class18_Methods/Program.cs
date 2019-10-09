/// Professor Campbell
/// October 11, 2017
/// Demo of void and value-returning methods
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class18_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, class!");

            int num1 = 0, num2 = 0;
            Console.Write("Enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid. Enter a valid integer: ");
            }

            Console.Write("Enter another number: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid. Enter a valid integer: ");
            }

            Console.WriteLine("\nRunning void method");
            ShowSum(num1, num2);

            Console.WriteLine("\nRunning value-returning method");
            int sum = CalculateSum(num1, num2);
            Console.WriteLine($"The value of sum is {sum}.");

            CloseWindow(1.5);
            

            Console.ReadLine();
        }

        private static int CalculateSum(int firstNum, int secondNum)
        {
            return (firstNum + secondNum);
        }

        private static void ShowSum(int firstNum, int secondNum)
        {
            Console.WriteLine($"The sum of {secondNum} and {firstNum} is {secondNum + firstNum}");
        }

        /// <summary>
        /// Closes the Console window after a specific amount of time
        /// </summary>
        private static void CloseWindow(double seconds)
        {
            int milliseconds = (int)(seconds * 1000);
            System.Threading.Thread.Sleep(milliseconds);
            Environment.Exit(0);
        }
    }
}
