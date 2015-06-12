using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code4Fun
{
    public static class Exercises
    {
        public static T GetNthElementFromRightInSinglePass<T>(IEnumerable<T> enumerable, int index)
        {
            var ringBuffer = new T[index];
            
            var counter = 0;
            foreach (var element in enumerable)
            {
                ringBuffer[counter++ % index] = element;
            }

            return ringBuffer[counter % index];
        }

        public static Int64[] GetArrayOfDistinctIntegerInRandomOrder(Int64 size)
        {
            var arrayOfDistinctIntegerInRandomOrder = new Int64[size];
            var arrayOfRandomDouble = new double[size];

            var random = new Random();

            /*    for (var i = 0; i < size;i++ )
              {
                  arrayOfDistinctIntegerInRandomOrder[i] = i + 1;

                  arrayOfRandomDouble[i] = random.NextDouble();
              }

              Array.Sort(arrayOfRandomDouble, arrayOfDistinctIntegerInRandomOrder);
               */

                var usedBuffer = new bool[size];            
                var j = 0L;

                for (var i = 0; i < size; i++)
                {
                    var r = DateTime.Now.Ticks % size; //random.Next(size);
                    if (usedBuffer[r])
                    {
                        if (j % 2 == 0)
                        {
                            r = Array.LastIndexOf(usedBuffer,  false);
                        }
                        else
                        {
                            r = Array.IndexOf(usedBuffer, false);
                        }

                        j++;
                    }

                    usedBuffer[r] = true;

                    arrayOfDistinctIntegerInRandomOrder[i] = r + 1;
                }

                return arrayOfDistinctIntegerInRandomOrder;
        }
    }
}
