using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_06_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Age Checker";

            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 13)
            {
                Console.WriteLine("You can watch a PG-13 movie");
            }

            if (userAge >= 14)
            {
                Console.WriteLine("You can obtain a learner's permit");
            }

            if (userAge >= 16)
            {
                Console.WriteLine("You can obtain a driver's license");
                Console.WriteLine("You are old enough to work");
            }

            if (userAge >= 18)
            {
                Console.WriteLine("You are eligible to vote");
                Console.WriteLine("You can live independently without parental supervision");
                Console.WriteLine("You are eligible for the military draft");
                Console.WriteLine("You can become an organ donor");
                Console.WriteLine("You can play M-rated games");
            }

            if (userAge >= 21)
            {
                Console.WriteLine("You are old enough to buy alcohol");
                Console.WriteLine("You are old enough to buy cigarettes");
            }
            else
            {
                Console.WriteLine("You are not old enough to buy alcohol or cigarettes");
                Console.WriteLine("That's OK, this stuff is bad for you anyway");
            }

            Console.ReadLine();
        }
    }
}
