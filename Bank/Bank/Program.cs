using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(5000);
            ShowData(account);
            account.Withdraw(2000);
            ShowData(account);
            account.Deposit(1000);
            ShowData(account);

            Console.ReadLine();

            void ShowData(Account _account)
            {
                var accountNumber = account.AccountNumber;
                var balance = account.Balance;
                var accountType = account.AccountType;

                Console.WriteLine($"{nameof(accountNumber)}: {accountNumber}");
                Console.WriteLine($"{nameof(balance)}: {balance}");
                Console.WriteLine($"{nameof(accountType)}: {accountType}");
            }
        }
    }
}
