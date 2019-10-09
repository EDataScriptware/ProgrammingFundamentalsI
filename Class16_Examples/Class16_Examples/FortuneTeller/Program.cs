using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fortune Teller";
            int age = 0;
            Console.Write("What's your age? ");
            const int RET_MULTIPLIER = 1000000;

            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Invalid input. Try again: ");
            }

            Console.WriteLine();
            Random r = new Random();

            double nestEgg = r.NextDouble() * RET_MULTIPLIER;

            Console.WriteLine($"You will have {r.Next(0,11)} kids");
            Console.WriteLine($"You will retire at {r.Next(age,75)}");
            Console.WriteLine($"Your 401(k) will be worth {nestEgg:c}.");

            Console.ReadLine();
        }
    }
}
