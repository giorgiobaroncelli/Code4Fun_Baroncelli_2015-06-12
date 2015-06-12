using Code4Fun;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PerformanceConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();

            //stopwatch.Start();
            var array = Exercises.GetArrayOfDistinctIntegerInRandomOrder(100);              
            //stopwatch.Stop();

            foreach (var x in array)
            {
                Console.Write(x + " ");
            }

            //Console.WriteLine("1 Time elapsed: {0}", stopwatch.Elapsed);

            //stopwatch.Start();
            //Exercises.GetArrayOfDistinctIntegerInRandomOrder(1000);
            //stopwatch.Stop();
            
            //Console.WriteLine("2 Time elapsed: {0}", stopwatch.Elapsed);

            //stopwatch.Start();
            //Exercises.GetArrayOfDistinctIntegerInRandomOrder(10000);
            //stopwatch.Stop();
            
            //Console.WriteLine("3 Time elapsed: {0}", stopwatch.Elapsed);

            //stopwatch.Start();
            //Exercises.GetArrayOfDistinctIntegerInRandomOrder(100000);
            //stopwatch.Stop();
            
            //Console.WriteLine("4 Time elapsed: {0}", stopwatch.Elapsed);

            //stopwatch.Start();
            //Exercises.GetArrayOfDistinctIntegerInRandomOrder(1000000);
            //stopwatch.Stop();
            
            //Console.WriteLine("5 Time elapsed: {0}", stopwatch.Elapsed);
            
            //stopwatch.Start();
            //Exercises.GetArrayOfDistinctIntegerInRandomOrder(10000000);
            //stopwatch.Stop();
            
            //Console.WriteLine("6 Time elapsed: {0}", stopwatch.Elapsed);
            
            Console.WriteLine();
        }
    }
}
