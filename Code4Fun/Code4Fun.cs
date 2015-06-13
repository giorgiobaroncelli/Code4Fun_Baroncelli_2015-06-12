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
            if (index < 1)
            {
                throw new ArgumentOutOfRangeException("Index must be greater than one");
            }

            var ringBuffer = new T[index];

            var counter = 0;
            foreach (var element in enumerable)
            {
                ringBuffer[counter++ % index] = element;
            }

            if (index > counter)
            {
                throw new ArgumentOutOfRangeException("Index must be less than size of enumerable");
            }

            return ringBuffer[counter % index];
        }

        public static Int32[] CreateArrayOfDistinctIntegerInRandomOrder(Int32 size)
        {
            if (size < 2)
            {
                throw new ArgumentOutOfRangeException("Size must be greater than one");
            }
            
            var sortedListOfInteger = new List<int>(size);
            for (var n = 1; n <= size; n++ )
            {
                sortedListOfInteger.Add(n);
            }

            var arrayOfDistinctIntegerInRandomOrder = new Int32[size];
            var random = new Random();

            for (var n = 0; n < size; n++)
            {
                var sortedListOfIntegerRandomIndex = random.Next(sortedListOfInteger.Count);

                arrayOfDistinctIntegerInRandomOrder[n] = sortedListOfInteger[sortedListOfIntegerRandomIndex];

                sortedListOfInteger.RemoveAt(sortedListOfIntegerRandomIndex);
            }

            return arrayOfDistinctIntegerInRandomOrder;
        }
    }
}
