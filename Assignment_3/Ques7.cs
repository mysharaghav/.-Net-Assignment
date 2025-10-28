// Q7: Define an abstract base class Shape with an abstract method CalculateArea.
// Derive classes like Circle and Rectangle from Shape and implement the area calculation methods.

using System;

namespace Assignment_3
{
    internal class Ques7
    {
        abstract class Shape
        {
            public abstract double CalculateArea();
        }

        class Circle : Shape
        {
            public double Radius { get; set; }
            public override double CalculateArea() => Math.PI * Radius * Radius;
        }

        class Rectangle : Shape
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public override double CalculateArea() => Length * Width;
        }

        static void Main(string[] args)
        {
            Circle c = new Circle { Radius = 5 };
            Rectangle r = new Rectangle { Length = 4, Width = 6 };

            Console.WriteLine("Circle Area: " + c.CalculateArea());
            Console.WriteLine("Rectangle Area: " + r.CalculateArea());
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
