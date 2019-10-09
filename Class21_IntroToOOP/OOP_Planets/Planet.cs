using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Planets
{
    class Planet
    {
        #region Attributes / Fields
        public string Name;
        public double OrbitInDays;
        public int NumberOfMoons;
        public int Diameter;
        #endregion

        #region Constructors

        public Planet() {}
        public Planet(string name, double orbit, int moons, int diameter)
        {
            Name = name;
            OrbitInDays = orbit;
            NumberOfMoons = moons;
            Diameter = diameter;
        }
        #endregion

        #region Behavior / Methods
        public void PrintDetails()
        {
            Console.WriteLine($"{Name}\t\t{Diameter}\t\t{OrbitInDays}\t\t{NumberOfMoons}");
        }
        #endregion
    }
}
