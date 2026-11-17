using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatch_Block
{
    using System;

    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message)
            : base(message)
        {
        }
    }

    class Bank
    {
        static void Withdraw(int balance, int amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException(
                    "Insufficient account balance"
                );
            }

            Console.WriteLine("Withdrawal successful");
        }

        static void Main()
        {
            try
            {
                Withdraw(1000, 2000);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
