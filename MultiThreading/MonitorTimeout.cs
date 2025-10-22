using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class MonitorTimeout
    {
        static readonly object resourceA = new object();
        static readonly object resourceB = new object();

        static void Main56()
        {
            Thread t1 = new Thread(Thread1Work);
            Thread t2 = new Thread(Thread2Work);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Both threads completed.");
        }

        static void Thread1Work()
        {
            bool lockedA = false;
            bool lockedB = false;

            try
            {
                // Try to obtain lock on A first (wait up to 1000 ms)
                lockedA = Monitor.TryEnter(resourceA, 1000);
                if (!lockedA)
                {
                    Console.WriteLine("Thread 1: could not acquire Resource A (timeout)");
                    return;
                }
                Console.WriteLine("Thread 1: locked Resource A");

                Thread.Sleep(5000); // simulate some work while holding A

                // Now try to obtain lock on B, but only wait a short time
                lockedB = Monitor.TryEnter(resourceB, 1000);
                if (!lockedB)
                {
                    Console.WriteLine("Thread 1: could not acquire Resource B (avoiding deadlock)");
                    return;
                }
                Console.WriteLine("Thread 1: locked Resource B");

                // Both locks acquired — perform combined work
                Console.WriteLine("Thread 1: working with A and B");
            }
            finally
            {
                if (lockedB)
                {
                    Monitor.Exit(resourceB);
                    Console.WriteLine("Thread 1: released Resource B");
                }
                if (lockedA)
                {
                    Monitor.Exit(resourceA);
                    Console.WriteLine("Thread 1: released Resource A");
                }
            }
        }

        static void Thread2Work()
        {
            bool lockedB = false;
            bool lockedA = false;

            try
            {
                // Try to obtain lock on B first (wait up to 1000 ms)
                lockedB = Monitor.TryEnter(resourceB, 1000);
                if (!lockedB)
                {
                    Console.WriteLine("Thread 2: could not acquire Resource B (timeout)");
                    return;
                }
                Console.WriteLine("Thread 2: locked Resource B");

                Thread.Sleep(5000); // simulate some work while holding B

                // Now try to obtain lock on A
                lockedA = Monitor.TryEnter(resourceA, 1000);
                if (!lockedA)
                {
                    Console.WriteLine("Thread 2: could not acquire Resource A (avoiding deadlock)");
                    return;
                }
                Console.WriteLine("Thread 2: locked Resource A");

                // Both locks acquired — perform combined work
                Console.WriteLine("Thread 2: working with B and A");
            }
            finally
            {
                if (lockedA)
                {
                    Monitor.Exit(resourceA);
                    Console.WriteLine("Thread 2: released Resource A");
                }
                if (lockedB)
                {
                    Monitor.Exit(resourceB);
                    Console.WriteLine("Thread 2: released Resource B");
                }
            }
        }
    }
}
