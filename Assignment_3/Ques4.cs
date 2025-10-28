// Q4: Implement a static logger class called Logger that has a method LogMessage
// for writing messages on console. Demonstrate its usage.

using System;

namespace Assignment_3
{
    internal class Ques4
    {
        static class Logger
        {
            public static void LogMessage(string message)
            {
                Console.WriteLine($"[LOG]: {message}");
            }
        }

        static void Main(string[] args)
        {
            Logger.LogMessage("Application started");
            Logger.LogMessage("Processing data...");
            Logger.LogMessage("Application ended");
            Console.WriteLine("Developed By Gaurav Roll-16");
        }
    }
}
