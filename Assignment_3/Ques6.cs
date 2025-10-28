// Q6: Create a partial class Employee with properties representing employee details.
// In another part, implement methods for calculating salary based on different factors.

using System;

namespace Assignment_3
{
    internal class Ques6
    {
        partial class Employee
        {
            public string Name { get; set; }
            public double BasicSalary { get; set; }
            public double Allowance { get; set; }
        }

        partial class Employee
        {
            public double CalculateSalary()
            {
                return BasicSalary + Allowance;
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee { Name = "Utkarsh", BasicSalary = 25000, Allowance = 5000 };
            Console.WriteLine($"{emp.Name}'s Salary: {emp.CalculateSalary()}");
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
