using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Planets of the Solar System";

            // First planet object, created with default constructor
            Planet p1 = new Planet();
            p1.Name = "Mercury";
            p1.OrbitInDays = 88;
            p1.Diameter = 1516;
            p1.NumberOfMoons = 0;

            // Second planet, also created with default constructor
            Planet p2 = new Planet();
            p2.Name = "Venus";
            p2.OrbitInDays = 224.7;
            p2.Diameter = 4590;
            p2.NumberOfMoons = 0;

            // Add other planets using parameterized constructor
            Planet p3 = new Planet("Earth", 365.25, 1, 4700);
            Planet p4 = new Planet("Mars", 578, 2, 3800);

            Console.WriteLine("Name\t\tDiameter\tOrbit in Days\t# Moons");
            Console.WriteLine("----\t\t--------\t-------------\t-------");
            p1.PrintDetails();
            p2.PrintDetails();
            p3.PrintDetails();
            p4.PrintDetails();

            Console.ReadLine();
        }
    }
}
