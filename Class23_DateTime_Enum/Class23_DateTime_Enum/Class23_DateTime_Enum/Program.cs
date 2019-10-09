using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class23_DateTime_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DateTime";

            DateTime dob = new DateTime(1973, 2, 9, 22, 30, 0, 0);
            DateTime now = DateTime.Now;

            Console.WriteLine("{0:y yy yyy yyyy}", dob);        // Year
            Console.WriteLine("{0:M MM MMM MMMM}", dob);        // Month
            Console.WriteLine("{0:d dd ddd dddd}", dob);        // Day
            Console.WriteLine("{0:h hh H HH}", dob);            // Hour
            Console.WriteLine("{0:m mm}", dob);                 // Minutes
            Console.WriteLine("{0:s ss}", dob);                 // Seconds
            Console.WriteLine("{0:t tt}", dob);                 // AM / PM
            Console.WriteLine("{0:M/d/yyyy}", dob);             // Abbrev date
            Console.WriteLine("{0:MM/dd/yyyy}", dob);           // Date with leading zeroes
            Console.WriteLine("{0:ddd, MMM d, yyyy}", dob);     // Full date with short day of week
            Console.WriteLine("{0:dddd, MMMM d, yyyy}", dob);   // Full date with long day of week
            Console.WriteLine("{0:MM/dd/yy}", dob);             // Date with 2 digit year
            Console.WriteLine("{0:MM/dd/yyyy}", dob);           // Date with 4 digit year

            Console.WriteLine(now-dob);

            Console.WriteLine("2017 : " + DateTime.IsLeapYear(2017));
            Console.WriteLine("2020 : " + DateTime.IsLeapYear(2020));

            Console.ReadLine();

        }
    }
}
