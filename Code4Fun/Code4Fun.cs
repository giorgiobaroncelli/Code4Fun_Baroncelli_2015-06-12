using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code4Fun
{
    public static class Code4Fun
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

            for (var i = 0; i < size;i++ )
            {
                arrayOfDistinctIntegerInRandomOrder[i] = i + 1;

                arrayOfRandomDouble[i] = random.NextDouble();
            }

            Array.Sort(arrayOfRandomDouble, arrayOfDistinctIntegerInRandomOrder);
              
            return arrayOfDistinctIntegerInRandomOrder;
        }
    }
}
