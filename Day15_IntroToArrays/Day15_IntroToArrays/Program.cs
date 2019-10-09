using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_IntroToArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Monthly Rainfall";

            const int NUM_MONTHS = 12;

            //string[] months = new string[NUM_MONTHS];
            //months[0] = "January";
            //months[1] = "February";
            //months[2] = "March";
            //months[3] = "April";
            //months[4] = "May";
            //months[5] = "June";
            //months[6] = "July";
            //months[7] = "August";
            //months[8] = "September";
            //months[9] = "October";
            //months[10] = "November";
            //months[11] = "December";

            string[] months = { "January", "February","March","April","May",
                "June","July","August","September", "October", "November","December" };

            double[] rainfall = { 3.71, 4.23, 3.17, 7.51, 5.23, 0.8, 2.35, 1.79, 3.51, 4.57, 5.77, 6.19 };

            double total = 0, average = 0;
            double highest = rainfall[0];
            double lowest = rainfall[0];
            string highestMonth = "", lowestMonth = "";

            for (int i = 0; i < months.Length; i++)
            {
                Console.Write((i+1) + "\t" + months[i]);

                if (months[i].Length > 7)
                {
                    Console.WriteLine("\t" + rainfall[i]);
                }
                else
                {
                    Console.WriteLine("\t\t" + rainfall[i]);
                }

                total += rainfall[i];

                // Compare current array value with highest value
                if (rainfall[i] > highest)
                {
                    highest = rainfall[i];
                    highestMonth = months[i];
                }

                // Compare current array value with lowest value
                if (rainfall[i] < lowest)
                {
                    lowest = rainfall[i];
                    lowestMonth = months[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Total Rainfall: {total}");

            average = total / NUM_MONTHS;
            Console.WriteLine($"Average Montly Rainfall: {average:n2}");

            Console.WriteLine($"Highest Monthly Rainfall: {highest} in {highestMonth}");
            Console.WriteLine($"Lowest Monthly Rainfall: {lowest} in {lowestMonth}");
            Console.ReadLine();

        }
    }
}
