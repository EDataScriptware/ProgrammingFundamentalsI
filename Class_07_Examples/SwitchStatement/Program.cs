/* Switch statement
 * Professor Campbell
 * 9/13/17
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Seasons";

            //Console.WriteLine("Hey! What's your favorite season?");
            //string favSeason = Console.ReadLine();

            //switch (favSeason) // Test variable
            //{
            //    case "Fall":
            //        Console.WriteLine("Fall in Rochester is CHAMP! There is over 150 species of trees here, with various hues. It's lovely in October!");
            //        break;
            //    case "Winter":
            //        Console.WriteLine("It's great in Rochester IF it snows. Otherwise, it's gloomy, muddy, and windy.");
            //        break;
            //    case "Spring":
            //        Console.WriteLine("Spring is great, but it's SHORT. Maybe 2 weeks.");
            //        break;
            //    case "Summer":
            //        Console.WriteLine("Summers in Rochester are mild and pleasant. Too bad RIT students aren't here to enjoy it.");
            //        break;
            //    default:
            //        Console.WriteLine("I didn't understand what you typed.");
            //        break;
            //}

            Console.WriteLine("MENU: ");
            Console.WriteLine("1) Pizza");
            Console.WriteLine("2) Buffalo Wings");
            Console.WriteLine("3) Garbage Plate");
            Console.Write("Enter your choice: ");

            switch(int.Parse(Console.ReadLine()))
            {
                case 1: Console.WriteLine("You ordered a pizza"); break;
                case 2: Console.WriteLine("May I suggest Jeremiah's Tavern"); break;
                case 3: Console.WriteLine("Nick Tahou's. Anywhere else is unacceptable"); break;
            }





            // Close this window after 2 seconds
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
