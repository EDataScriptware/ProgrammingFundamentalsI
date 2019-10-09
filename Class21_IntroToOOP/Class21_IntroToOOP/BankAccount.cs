using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class21_IntroToOOP
{
    class BankAccount
    {
        #region Fields
        // Fields
        private double Balance;
        private string CustomerName;
        #endregion

        #region Constructors
        public BankAccount(double balance, string name)
        {
            this.Balance = balance;
            this.CustomerName = name;
        }
        #endregion

        #region Methods
        // Methods
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public double GetBalance()
        {
            return Balance;
        }
        #endregion  
    }
}
