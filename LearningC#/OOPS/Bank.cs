using System;
using System.Collections.Generic;
using System.Text;

namespace LearningC_.OOPS
{
    class Bank
    {
        public int AccountNo { get; private set; }

        public string AccHolder { get; private set; }

        public decimal Balance { get; private set; }

        public Bank(int accountNo, string holder)
            : this(accountNo, holder, 0)
        {
        }

        public Bank(int accountNo, string holder, decimal balance)
        {
            if (balance < 0)
                throw new ArgumentException("Invalid balance");
                
            AccountNo = accountNo;
            AccHolder = holder;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit");
                return;
            }

            Balance += amount;
            Console.WriteLine("Deposit successful");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            Balance -= amount;
            Console.WriteLine("Withdrawal successful");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Current Balance: {Balance}");
        }
    }
}
