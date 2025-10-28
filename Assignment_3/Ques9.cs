// Q9: Create a base class Vehicle with methods like StartEngine and StopEngine.
// Derive a class Car from Vehicle and seal it. Try to create another class inheriting Car and observe behavior.

using System;

namespace Assignment_3
{
    internal class Ques9
    {
        class Vehicle
        {
            public void StartEngine() => Console.WriteLine("Engine Started");
            public void StopEngine() => Console.WriteLine("Engine Stopped");
        }

        sealed class Car : Vehicle
        {
            public void Drive() => Console.WriteLine("Car is driving");
        }

        // This will cause error if uncommented:
        // class SportsCar : Car { }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartEngine();
            car.Drive();
            car.StopEngine();
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
