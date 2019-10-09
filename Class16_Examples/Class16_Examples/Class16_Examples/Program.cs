using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class16_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // To assign a random number to each element
            const int ROWS = 3;
            const int COLS = 4;
            int[,] scores = new int[ROWS, COLS];
            Random rn = new Random();

            // Populate 2D array with random values
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    scores[row, col] = rn.Next(50, 101);
                    
                }
            }

            // To show each value in a 2-D array
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Console.Write(scores[row, col] + " ");
                    System.Threading.Thread.Sleep(500);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
