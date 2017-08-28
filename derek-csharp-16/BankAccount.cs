using System;

namespace derek_csharp_16
{
    class BankAccount
    {
        private object accountLock = new object();
        public double Balance { get; set; }

        public BankAccount(double balance)
        {
            Balance = balance;
        }

        public double Withdraw(double amount)
        {
            if ((Balance - amount) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;
            }

            lock (accountLock)
            {
                if (Balance >= amount)
                {
                    Console.WriteLine("Removed {0} and {1} left in Account", amount, (Balance - amount));
                    Balance -= amount;
                }
                return Balance;
            }
        }

        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
}