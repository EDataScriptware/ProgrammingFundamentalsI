using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianCurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const double US_TO_CAN = 1.22;

            Console.Title = "Canadian Currency Converter";

            Console.WriteLine("US Dollars\tCanadian Dollars");
            Console.WriteLine("----------\t----------------");
            for (int i = 5; i <= 100; i+= 5)
            {
                Console.WriteLine($"{i:c}\t\t{i*US_TO_CAN:c}");
            }

            Console.ReadLine();

        }
    }
}
