using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class WithLock
    {
        static int counter = 0;
        static readonly object locker = new object();

        static void Main2()
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Final Counter (With Lock): " + counter);
        }

        static void Increment()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (locker)
                {
                    counter++;
                }
            }
        }
    }
}
