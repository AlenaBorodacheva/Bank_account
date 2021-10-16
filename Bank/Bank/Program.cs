using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            ShowData(account1);
            Account account2 = new Account(5000);
            ShowData(account2);
            Account account3 = new Account(BankAccountType.Savings);
            ShowData(account3);
            Account account4 = new Account(7000, BankAccountType.FixedDeposit);
            ShowData(account4);

            Console.ReadLine();

            void ShowData(Account account)
            {
                var accountNumber = account.ReadAccountNumber();
                var balance = account.ReadBalance();
                var accountType = account.ReadBankAccountType();

                Console.WriteLine($"{nameof(accountNumber)}: {accountNumber}");
                Console.WriteLine($"{nameof(balance)}: {balance}");
                Console.WriteLine($"{nameof(accountType)}: {accountType}");
            }
        }
    }
}
