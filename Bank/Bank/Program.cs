using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(5000);
            Account account2 = new Account(3000);
            ShowData(account1);
            ShowData(account2);
            Console.WriteLine();
            account1.GetMoneyFrom(account2, 1000);
            ShowData(account1);
            ShowData(account2);

            string myString = "Hello world";
            WorkingWithStrings str = new WorkingWithStrings();
            Console.WriteLine(str.TurnOver(myString));

            str.CreateEmailFile(Environment.CurrentDirectory + "\\EmailBook.txt");

            Console.ReadLine();

            void ShowData(Account _account)
            {
                var accountNumber = _account.AccountNumber;
                var balance = _account.Balance;
                var accountType = _account.AccountType;

                Console.WriteLine($"{nameof(accountNumber)}: {accountNumber}");
                Console.WriteLine($"{nameof(balance)}: {balance}");
                Console.WriteLine($"{nameof(accountType)}: {accountType}");
            }
        }
    }
}
