using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static int counter = 0;

        static void Main3(String[]args)
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Final Counter (Without Lock): " + counter);
        }

        static void Increment()
        {
            for (int i = 0; i < 1_00_000; i++)
            {
                // Multiple threads access counter simultaneously
                counter++;
            }
        }
    }
}
