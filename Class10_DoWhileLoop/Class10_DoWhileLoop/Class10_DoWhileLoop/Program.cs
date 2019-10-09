/*
 * Examples: Do While Loop, Nested Loop, Use of Loops to Validate Input
 * Professor Campbell
 * September 20, 2017
 * NMAD-180
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;

            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //} while (i < 10);

            int age;

            do
            {
                Console.Write("Enter your age: ");
            } while (!int.TryParse(Console.ReadLine(), out age));

            Console.WriteLine("\nYou are " + age + " years old.");
            Console.ReadLine();

            // NESTED LOOP EXAMPLE
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"i ={i}, j = {j}");
            //        System.Threading.Thread.Sleep(500);
            //    }
            //}

            // EXAMPLE OF HOW TO REPEATEDLY ASK FOR VALID INPUT
            //int age;
            //const int DOG_YEARS = 7;
            //Console.Write("Enter your age: ");

            //while (!int.TryParse(Console.ReadLine(), out age))
            //{
            //    Console.Write("Invalid input. Try again. Enter a valid integer value: ");
            //}

            //Console.WriteLine($"You are {age * DOG_YEARS} years old in dog years.");

            //Console.ReadLine();
        }
    }
}
