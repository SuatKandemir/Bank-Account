using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Counts
{
    class Account
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public Account(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} TL has been deposited to the account named {AccountHolder}. New balance: {Balance} TL");
            }
            else
            {
                Console.WriteLine("Invalid amount. Enter a positive value.");
            }
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} TL was withdrawn from the account named {AccountHolder}. New balance: {Balance} TL");
            }
            else if (Balance < amount)
            {
                Console.WriteLine("Insufficient Funds");
            }
            else
            {
                Console.WriteLine("Invalid amount. Enter a positive value.");
            }
        }

        public void BalanceInquiry()
        {
            Console.WriteLine($"Balance of the account named {AccountHolder}: {Balance} TL");
        }
    }
}