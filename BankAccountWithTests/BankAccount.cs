using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWithTests
{
    public class BankAccount
    {
        private string accountNumber;

        public BankAccount(string accNum)
        {
            AccountNumber = accNum;
        }

        public string AccountNumber 
        {
            get 
            { 
                return accountNumber; 
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Account number cannot be null or whitespace");
                }
                accountNumber = value; 
            }   
        }

        public string Owner { get; set; }

        public double Balance { get; private set; }

        /// <summary>
        /// Deposits a positive amount of money
        /// into the account and returns the new
        /// <see cref="Balance"/>
        /// </summary>
        /// <exception cref="ArgumentException">
        ///     Thrown when <paramref name="amt"/> is 0 or less
        /// </exception>
        /// <param name="amt">The amount of money to deposit</param>
        public double Deposit(double amt)
        {
            if (amt <= 0)
            {
                throw new ArgumentException("You must deposit a positive amount");
            }

            Balance += amt;
            return Balance;
        }
    }
}
