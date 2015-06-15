using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //for(var i = 1; i<6;i++)
                //{
                    
                    var sw = new System.Diagnostics.Stopwatch();
                    sw.Start();

                    var size = 100;
                    //for(var j=0;j<i;j++)
                    //{
                    //    size = size * 10; 
                    //}

                    var array = Code4Fun.Code4Fun.CreateArrayOfDistinctIntegerInRandomOrder(size);
                
                    sw.Stop();

                    //Console.WriteLine(size + ": " + sw.ElapsedMilliseconds);
                    //Console.WriteLine();

                    //sw.Start();

                    //array = Code4Fun.Code4Fun.CreateArrayOfDistinctIntegerInRandomOrder(size, false);


                    //sw.Stop();

                    //Console.WriteLine(size + ": " + sw.ElapsedMilliseconds);
                    //Console.WriteLine();

                //}

                    foreach (var x in array)
                    {
                        Console.Write(x + " ");
                    }

                Console.WriteLine();
                Console.ReadLine();
            }
            while (true);
        }
    }
}
