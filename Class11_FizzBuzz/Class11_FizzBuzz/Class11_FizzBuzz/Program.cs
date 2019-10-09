/*
 * FizzBuzz Game
 * Professor Chris Campbell
 * September 22, 2017
 * PURPOSE: Use of loops to validate user input and ask if user wants to re-run program
 */
using System;

namespace Class11_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fizz Buzz Game";
            Console.ForegroundColor = ConsoleColor.White;
            string continueProgram = "Y";
            int stopAtNumber = 0;
            bool validValue;

            do
            {
                Console.Clear();
                Console.Write("Enter a value over 0: ");


                validValue = false;
                while (!validValue)
                {
                    while (!int.TryParse(Console.ReadLine(), out stopAtNumber))
                    {
                        Console.Write("Invalid input. Try again: ");
                    }

                    if (stopAtNumber <= 0)
                    {
                        Console.Write("Invalid input. Must be positive. Try again: ");
                    }
                    else
                    {
                        validValue = true;
                    }
                }

                int i = 1;
                while (i <= stopAtNumber)
                {
                    if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(i);
                    }
                    System.Threading.Thread.Sleep(200);
                    i++;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Re-run program? Press Y to continue, any other key to quit.");
                continueProgram = Console.ReadLine();
            } while (continueProgram == "Y" || continueProgram == "y");


            Console.WriteLine("Thank you for playing!");
            System.Threading.Thread.Sleep(1500);
            Environment.Exit(0);
        }
    }
}