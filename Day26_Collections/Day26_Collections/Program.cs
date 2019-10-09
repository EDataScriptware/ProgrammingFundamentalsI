using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Day 26 - Collections";

            //// Create array of Planet objects
            //Planet[] solarSystem = new Planet[9];
            //solarSystem[0] = new Planet("Mercury", "Terrestrial", 3031, 88);
            //solarSystem[1] = new Planet("Venus", "Terrestrial", 7521, 225);
            //solarSystem[2] = new Planet("Earth", "Terrestrial", 7926, 365.24);
            //solarSystem[3] = new Planet("Mars", "Terrestrial", 4217, 687);
            //solarSystem[4] = new Planet("Jupiter", "Jovian", 88730, 4332.38);
            //solarSystem[5] = new Planet("Saturn", "Jovian", 74900, 10759);
            //solarSystem[6] = new Planet("Uranus", "Jovian", 31763, 30680.16);
            //solarSystem[7] = new Planet("Neptune", "Jovian", 30775, 60187.9);
            //solarSystem[8] = new Planet("Pluto", "Dwarf", 1430, 90557.61);

            //Console.WriteLine("Name           Type            Diameter(mi)        Orbit(days)      Orbit(years)");
            //Console.WriteLine("----           ----            ------------        -----------      ------------");

            //// Count how many terrestrial (rocky) planets we have
            //int rocky = 0;

            //// Count how many Jovian (gas giant) planets we have
            //int gas = 0;

            //// Loop through array and display each planet
            //foreach(Planet p in solarSystem)
            //{
            //    Console.WriteLine(p);

            //    switch(p.Type)
            //    {
            //        case "Terrestrial": rocky++; break;
            //        case "Jovian": gas++; break;
            //    }
            //}

            //Console.WriteLine($"\nThere are {rocky} terrestrial planets.");
            //Console.WriteLine($"\nThere are {gas} Jovian planets.");

            // Create List of Planet objects
            List<Planet> solarSystem = new List<Planet>();
            solarSystem.Add(new Planet("Mercury", "Terrestrial", 3031, 88));
            solarSystem.Add(new Planet("Venus", "Terrestrial", 7521, 225));
            solarSystem.Add(new Planet("Earth", "Terrestrial", 7926, 365.24));
            solarSystem.Add(new Planet("Mars", "Terrestrial", 4217, 687));
            solarSystem.Add(new Planet("Jupiter", "Jovian", 88730, 4332.38));
            solarSystem.Add(new Planet("Saturn", "Jovian", 74900, 10759));
            solarSystem.Add(new Planet("Uranus", "Jovian", 31763, 30680.16));
            solarSystem.Add(new Planet("Neptune", "Jovian", 30775, 60187.9));
            solarSystem.Add(new Planet("Pluto", "Dwarf", 1430, 90557.61));

            // Let's remove Pluto, because it's not REALLY a planet...
            solarSystem.RemoveAt(8);

            Console.WriteLine("Name           Type            Diameter(mi)        Orbit(days)      Orbit(years)");
            Console.WriteLine("----           ----            ------------        -----------      ------------");

            // Count how many terrestrial (rocky) planets we have
            int rocky = 0;

            // Count how many Jovian (gas giant) planets we have
            int gas = 0;

            // Loop through array and display each planet
            foreach (Planet p in solarSystem)
            {
                Console.WriteLine(p);

                switch (p.Type)
                {
                    case "Terrestrial": rocky++; break;
                    case "Jovian": gas++; break;
                }
            }

            Console.WriteLine($"\nThere are {rocky} terrestrial planets.");
            Console.WriteLine($"\nThere are {gas} Jovian planets.");

            Console.ReadLine();
        }
    }
}
