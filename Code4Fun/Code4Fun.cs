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

        //public static Int32[] CreateArrayOfDistinctIntegerInRandomOrder(Int32 size)
        //{
        //    if (size < 2)
        //    {
        //        throw new ArgumentOutOfRangeException("Size must be greater than one");
        //    }

        //    var sortedListOfInteger = new List<int>(size);
        //    for (var n = 1; n <= size; n++ )
        //    {
        //        sortedListOfInteger.Add(n);
        //    }

        //    var arrayOfDistinctIntegerInRandomOrder = new Int32[size];
        //    var random = new Random();

        //    for (var n = 0; n < size; n++)
        //    {
        //        var sortedListOfIntegerRandomIndex = 
        //            random.Next(sortedListOfInteger.Count);

        //        arrayOfDistinctIntegerInRandomOrder[n] = 
        //            sortedListOfInteger[sortedListOfIntegerRandomIndex];

        //        sortedListOfInteger[sortedListOfIntegerRandomIndex] =
        //           sortedListOfInteger[sortedListOfInteger.Count - 1];

        //        sortedListOfInteger.RemoveAt(sortedListOfInteger.Count - 1);
        //    }

        //    return arrayOfDistinctIntegerInRandomOrder;
        //}

        public static IEnumerable<int> CreateArrayOfDistinctIntegerInRandomOrder(Int32 size)
        {
            if (size < 2)
            {
                throw new ArgumentOutOfRangeException("Size must be greater than one");
            }

            Random r = new Random();
            int M = Code4Fun.NextLargestPowerOfTwo(size);
            int c = r.Next(M / 2) * 2 + 1; // make c any odd number between 0 and M
            int a = r.Next(M / 4) * 4 + 1; // M = 2^m, so make (a-1) divisible by all prime factors, and 4

            int start = r.Next(M);
            int x = start;
            do
            {
                x = (a * x + c) % M;
                if (x < size )
                    yield return x + 1;
            } while (x != start);
        }

        private static int NextLargestPowerOfTwo(int n)
        {
            n |= (n >> 1);
            n |= (n >> 2);
            n |= (n >> 4);
            n |= (n >> 8);
            n |= (n >> 16);
            return (n + 1);
        }

    }
}
