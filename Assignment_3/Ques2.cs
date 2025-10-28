// Q2: Create a class called BankAccount with properties for account number, account holder name, and balance.
// Implement methods for deposit, withdrawal, and displaying the account details.

using System;

namespace Assignment_3
{
    internal class Ques2
    {
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public string HolderName { get; set; }
            public double Balance { get; set; }

            public void Deposit(double amount) => Balance += amount;
            public void Withdraw(double amount)
            {
                if (amount <= Balance) Balance -= amount;
                else Console.WriteLine("Insufficient Balance");
            }
            public void Display()
            {
                Console.WriteLine($"Account: {AccountNumber}, Holder: {HolderName}, Balance: {Balance}");
            }
        }

        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount { AccountNumber = 101, HolderName = "Utkarsh", Balance = 5000 };
            acc.Deposit(1500);
            acc.Withdraw(2000);
            acc.Display();
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
