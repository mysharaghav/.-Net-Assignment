using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MultiThreading
{
   
        internal class UniqueNumberGenerator
        {
            static void Main(string[] args)
            {
                Random rand = new Random();
                HashSet<int> numbers = new HashSet<int>();

               
                while (numbers.Count < 1000)
                {
                    int num = rand.Next(1, 100001);
                    numbers.Add(num);
                }

                string filePath = "unique_numbers.csv";

                
                string csvLine = string.Join(",", numbers);

                File.AppendAllText(filePath, csvLine + Environment.NewLine);

                Console.WriteLine("1000 unique numbers generated and appended to CSV file successfully.");
                Console.WriteLine("Developed By Utkarsh Roll-48");
            }
        }
    }


