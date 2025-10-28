// Q10: Design a class BankAccount with properties like AccountNumber and Balance.
// Implement a sealed class SavingsAccount that extends BankAccount with methods for interest calculation.

using System;

namespace Assignment_3
{
    internal class Ques10
    {
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public double Balance { get; set; }
        }

        sealed class SavingsAccount : BankAccount
        {
            public double InterestRate { get; set; }

            public void CalculateInterest()
            {
                double interest = Balance * InterestRate / 100;
                Console.WriteLine($"Interest: {interest}");
            }
        }

        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount { AccountNumber = 123, Balance = 10000, InterestRate = 5 };
            sa.CalculateInterest();
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
