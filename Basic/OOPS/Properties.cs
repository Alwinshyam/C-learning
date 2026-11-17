using System;

class BankAccount
{
    private int balance;

    public int Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount bank = new BankAccount();

        bank.Balance = 5000; //setter
        Console.WriteLine("Balance = " + bank.Balance);//getter

        bank.Balance = -1000;
        Console.WriteLine("Balance = " + bank.Balance);
    }
}