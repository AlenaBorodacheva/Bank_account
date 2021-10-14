﻿using System;
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

            account.CreateAccountNumber();
            account.WriteBalance(5000);
            account.WriteBankAccountType(BankAccountType.Current);

            var accountNumber = account.ReadAccountNumber();
            var balance = account.ReadBalance();
            var accountType = account.ReadBankAccountType();

            Console.WriteLine($"{nameof(accountNumber)}: {accountNumber}");
            Console.WriteLine($"{nameof(balance)}: {balance}");
            Console.WriteLine($"{nameof(accountType)}: {accountType}");

            account.CreateAccountNumber();
            var newAccountNumber = account.ReadAccountNumber();
            Console.WriteLine($"{nameof(newAccountNumber)}: {newAccountNumber}");

            Console.ReadLine();
        }
    }
}