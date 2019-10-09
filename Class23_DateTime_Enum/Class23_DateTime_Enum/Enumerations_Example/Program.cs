using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Enumerations";

            Student[] students = new Student[8];
            students[0] = new Student("Christine", Student.Gender.Female);
            students[1] = new Student("Suraj", Student.Gender.Male);
            students[2] = new Student("Sam", Student.Gender.Unknown);
            students[3] = new Student("Sayre", Student.Gender.Male);
            students[4] = new Student("Abenezer", Student.Gender.Male);
            students[5] = new Student("Edward", Student.Gender.Male);
            students[6] = new Student("Greg", Student.Gender.Male);
            students[7] = new Student("Amanda", Student.Gender.Female);

            foreach (Student s in students)
            {
                // Console.WriteLine($"{s.FirstName,-12} {s.GetGender(s.Gender)}");
                Console.WriteLine("{0,-15} {1}", s.FirstName, s.GetGender(s.StudentGender));
            }

            Console.ReadLine();
        }
    }
}
