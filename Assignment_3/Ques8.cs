// Q8: Design an abstract class Animal with properties like Name and Age.
// Derive classes like Dog and Cat from Animal with their unique methods.

using System;

namespace Assignment_3
{
    internal class Ques8
    {
        abstract class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public abstract void Speak();
        }

        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine($"{Name} (Dog): Woof Woof!");
            }
        }

        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine($"{Name} (Cat): Meow Meow!");
            }
        }

        static void Main(string[] args)
        {
            Dog d = new Dog { Name = "Tommy", Age = 3 };
            Cat c = new Cat { Name = "Kitty", Age = 2 };

            d.Speak();
            c.Speak();
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
