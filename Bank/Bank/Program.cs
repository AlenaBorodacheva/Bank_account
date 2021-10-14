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
            Account account = new Account();

            account.WriteAccountNumber(40888005553535123456M);
            account.WriteBalance(5000);
            account.WriteBankAccountType(BankAccountType.Current);

            var accountNumber = account.ReadAccountNumber();
            var balance = account.ReadBalance();
            var accountType = account.ReadBankAccountType();

            Console.WriteLine($"{nameof(accountNumber)}: {accountNumber}");
            Console.WriteLine($"{nameof(balance)}: {balance}");
            Console.WriteLine($"{nameof(accountType)}: {accountType}");

            Console.ReadLine();
        }
    }
}
