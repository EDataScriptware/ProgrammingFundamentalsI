using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Seasons";

            Console.WriteLine("Hey! What's your favorite season?");
            string favSeason = Console.ReadLine();

            if (favSeason == "Fall")
            {
                Console.WriteLine("Fall in Rochester is CHAMP! There is over 150 species of trees here, with various hues. It's lovely in October!");
            }
            else if (favSeason == "Winter")
            {
                Console.WriteLine("It's great in Rochester IF it snows. Otherwise, it's gloomy, muddy, and windy.");
            }
            else if (favSeason == "Spring")
            {
                Console.WriteLine("Spring is great, but it's SHORT. Maybe 2 weeks.");
            }
            else if (favSeason == "Summer")
            {
                Console.WriteLine("Summers in Rochester are mild and pleasant. Too bad RIT students aren't here to enjoy it.");
            }
            else
            {
                Console.WriteLine("I didn't understand what you typed.");
            }

            // Close this window after 2 seconds
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
