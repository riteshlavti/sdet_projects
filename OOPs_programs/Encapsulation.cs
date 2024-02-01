using System;
namespace EncapsulationProject
{
    public class BankAccount
    {
        private decimal balance; 
        public void Deposit(decimal amount) 
        {
            balance += amount;
        }
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