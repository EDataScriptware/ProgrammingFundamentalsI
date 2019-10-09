// Nested If Statement Example
// Professor Campbell
// 9/13/17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_07_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Presidential Campaign";
            Console.WriteLine("Interested in running for President of the US?");

            Console.Write("Were you born in the U.S.? ");
            string response = Console.ReadLine();

            if (response == "Y")
            {
                Console.Write("How old are you? ");
                int age = int.Parse(Console.ReadLine());

                if (age >= 35)
                {
                    Console.WriteLine("Congrats! You can run for President!");
                }
                else
                {
                    Console.WriteLine("Sorry, wait a few more years.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you have to be born in the US. That's why Arnold Schwarzenegger can't run");
            }

            // Close this window after 2 seconds
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
