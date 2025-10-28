// Q3: Create a static utility class named MathHelper with a static method CalculateAverage
// that takes an array of integers as input and returns their average.

using System;

namespace Assignment_3
{
    internal class Ques3
    {
        static class MathHelper
        {
            public static double CalculateAverage(int[] numbers)
            {
                int sum = 0;
                foreach (int n in numbers) sum += n;
                return (double)sum / numbers.Length;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Average: " + MathHelper.CalculateAverage(arr));
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
