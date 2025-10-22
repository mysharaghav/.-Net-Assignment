using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Ques1
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintNumber);
            t1.Start();
            Thread t2 = new Thread(PrintChar);
            t2.Start();
            t1.Join();
            t2.Join();
        }
        static void PrintNumber()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(200);
            }
            Console.WriteLine();
        }
        static void PrintChar()
        {
            for(char c = 'A'; c <= 'J'; c++)
            {
                Console.Write(c + " ");
                Thread.Sleep(300);
            }
            Console.WriteLine();
        }
    }
}
