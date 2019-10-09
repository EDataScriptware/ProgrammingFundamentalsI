using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_06_Logical_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Logical Operators";

            int x = 6;
            int y = 9;

            string a = "Bob";
            string b = "Bill";

            string myPassword = "dem72$0";

            Console.WriteLine(x < y);
            Console.WriteLine(x != y);

            Console.WriteLine(a == b);

            Console.Write("Enter your super duper secret password: ");
            string pwd = Console.ReadLine();

            if (pwd == myPassword)
            {
                Console.WriteLine("Greetings, master. What can I do for you today?");
            }
            else
            {
                Console.WriteLine("Buzz off!");
            }



            Console.ReadLine();
        }
    }
}
