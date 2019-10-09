using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26_Collections
{
    class Planet
    {
        const double EARTH_DAYS_IN_YEAR = 365.24;

        #region Fields
        private string name;
        private string type;
        private int diameter;
        private double orbitInDays;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public double OrbitInDays
        {
            get { return orbitInDays; }
            set { orbitInDays = value; }
        }

        public double OrbitInYears
        {
            get { return orbitInDays / EARTH_DAYS_IN_YEAR; }
        }
        #endregion

        #region Constructors
        // Parameterized constructor
        public Planet(string _name, string _type, int _diameter, double _orbitInDays)
        {
            Name = _name;
            Type = _type;
            Diameter = _diameter;
            OrbitInDays = _orbitInDays;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0,-15}{1,-15}{2,13}{3,19}{4,18}", Name, Type,
                Diameter, OrbitInDays, OrbitInYears);
        }
        #endregion  
    }
}
