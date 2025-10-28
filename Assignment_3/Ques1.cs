// Q1: Create a class called Employee with properties for name, age, and salary.
// Implement a method to display employee details.

using System;

namespace Assignment_3
{
    internal class Ques1
    {
        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }

            public void Display()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee { Name = "Gaurav", Age = 22, Salary = 45000 };
            emp.Display();
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
