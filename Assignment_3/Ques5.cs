// Q5: Define a partial class Person with one part containing properties like FirstName and LastName,
// and another part with methods like PrintFullName to display the full name.

using System;

namespace Assignment_3
{
    internal class Ques5
    {
        partial class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        partial class Person
        {
            public void PrintFullName()
            {
                Console.WriteLine($"Full Name: {FirstName} {LastName}");
            }
        }

        static void Main(string[] args)
        {
            Person p = new Person { FirstName = "Mysha", LastName = "Raghav" };
            p.PrintFullName();
            Console.WriteLine("Developed By Mysha");
        }
    }
}
