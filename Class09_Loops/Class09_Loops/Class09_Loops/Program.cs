using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class09_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // We need 3 things for a loop to run... what are they?
            // 1) Initialize loop control variable
            // 2) Test Boolean expression
            // 3) If loop is executed, update loop control variable

            int i = -10;

            Console.WriteLine("USING WHILE LOOP");
            while (i <= 50)
            {
                Console.Write(i + " ");
                System.Threading.Thread.Sleep(100);
                i = i + 2;
            }

            Console.WriteLine("\n\nUSING FOR LOOP");
            for (int j = -10; j <= 50000; j = j + 2)
            {
                Console.Write(j + " ");
                //System.Threading.Thread.Sleep(100);
            }




            Console.ReadLine();
        }
    }
}
