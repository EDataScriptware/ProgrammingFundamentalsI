using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_Example
{
    class Student
    {
        private string firstName;
        private Gender gender;

        public enum Gender
        {
            Unknown, 
            Male,
            Female
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public Gender StudentGender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Student() {}

        public Student(string firstName, Gender gender)
        {
            FirstName = firstName;
            StudentGender = gender;
        }

        public string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown: return "Unknown";
                case Gender.Male: return "Male";
                case Gender.Female: return "Female";
                default: return "Invalid data detected";
            }
        }
    }
}
