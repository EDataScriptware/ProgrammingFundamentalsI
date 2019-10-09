using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_Demo_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Weekend Survey";

            Console.WriteLine("What are you doing this weekend?");
            Console.WriteLine();
            Console.WriteLine("1) Sleep until 4pm");
            Console.WriteLine("2) Gaming, dude. Gaming all the time!");
            Console.WriteLine("3) Programming. Prof. Campbell gives me too much homework.");
            Console.WriteLine("4) Longboarding, while the weather is still nice.");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            int menuChoice;
            if (!int.TryParse(Console.ReadLine(), out menuChoice))
            {
                Console.WriteLine("Sorry, you entered an invalid menu choice.");
            }
            else
            {
                Console.WriteLine();
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("The weather this weekend is too nice to sleep in!");
                        break;
                    case 2:
                        Console.WriteLine("Save the gaming for when it's raining or snowing!");
                        break;
                    case 3:
                        Console.WriteLine("Um. Sorry.");
                        break;
                    case 4:
                        Console.WriteLine("Enjoy!");
                        break;
                    default:
                        Console.WriteLine("You entered a value that was not among your menu options.");
                        break;









                        











                }
            }
            

            Console.ReadLine();
        }
    }
}
