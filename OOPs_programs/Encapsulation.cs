using System;

namespace EncapsulationProject
{
    public class BankAccount
    {
        private decimal balance; 

        /// <summary>
        /// Deposit method is used to deposit amount in user's account.
        /// </summary>
        /// <param name="amount">It is the amount added by user.</param>
        public void Deposit(decimal amount) 
        {
            balance += amount;
        }

        /// <summary>
        /// Withdraw method is used to withdraw amount from user's account.
        /// </summary>
        /// <param name="amount">It is the amount withdrawn by user.</param>
        public void Withdraw(decimal amount) 
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        /// <summary>
        /// This method is used for returning user's balance.
        /// </summary>
        /// <returns></returns>
        public decimal GetBalance() 
        {
            return balance;
        }
    }

    class AccountAccess
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            account.Deposit(5000);
            Console.WriteLine("Account Balance - "+account.GetBalance());
            
            account.Withdraw(2000);
            Console.WriteLine("Account Balance - "+account.GetBalance());
        }
    }
}