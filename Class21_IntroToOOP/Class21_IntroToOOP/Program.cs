using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class21_IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount(1000, "Edward");

            b1.Deposit(750);
            b1.Withdraw(850);

            Console.WriteLine(b1.GetBalance().ToString("c"));

            Console.ReadLine();
        }
    }
}
