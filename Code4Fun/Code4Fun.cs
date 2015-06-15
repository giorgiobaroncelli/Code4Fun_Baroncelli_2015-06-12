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

        //from http://stackoverflow.com/questions/464476/generating-shuffled-range-using-a-prng-rather-than-shuffling#465473
        public static IEnumerable<Int32> CreateArrayOfDistinctIntegerInRandomOrder(Int32 size)
        {
            if (size < 2)
            {
                throw new ArgumentOutOfRangeException("Size must be greater than one");
            }

            Random r = new Random();
            int M = Code4Fun.NextLargestPowerOfTwo(size);
            int c = r.Next(M / 2) * 2 + 1; 
            int a = r.Next(M / 4) * 4 + 1; 

            int start = r.Next(M);
            Int64 x = start;
            do
            {
                x = ((a * x + c) % M);
                if (x < size)
                    yield return (Int32)x + 1;
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
