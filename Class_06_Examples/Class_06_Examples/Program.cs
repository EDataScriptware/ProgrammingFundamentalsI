using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_06_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Formatting Strings";

            double someValue = .085;
            double someOtherValue = 89.4234873489794;

            // This will format as currency... there are 3 ways to do this!
            Console.WriteLine(someOtherValue.ToString("c"));
            Console.WriteLine("{0:c} {1:c}", someOtherValue, someValue);
            Console.WriteLine($"{someOtherValue:c}");
            Console.WriteLine();

            // This will format a double value in percent format
            Console.WriteLine(someValue.ToString("p"));
            Console.WriteLine(someOtherValue.ToString("p"));

            // Fixed digit format
            Console.WriteLine();
            Console.WriteLine(someOtherValue.ToString("f2")); // 2 decimal places
            Console.WriteLine(someOtherValue.ToString("f5")); // 5 decimal places

            Console.ReadLine();

        }
    }
}
