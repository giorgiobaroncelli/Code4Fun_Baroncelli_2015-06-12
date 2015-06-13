using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Code4Fun
{
    public class CreateArrayOfDistinctIntegerInRandomOrderTest
    {
        private const Int32 ARRAY_SIZE = 10000;

        private readonly Int32[] array;

        public CreateArrayOfDistinctIntegerInRandomOrderTest()
        {
            this.array = Code4Fun.CreateArrayOfDistinctIntegerInRandomOrder(
                CreateArrayOfDistinctIntegerInRandomOrderTest.ARRAY_SIZE);
        }

        [Fact]
        public void ShouldThrownExceptionIfNthElementIsNotGreaterThanOne()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () =>
            {
                Code4Fun.CreateArrayOfDistinctIntegerInRandomOrder(1);
            });
        }

        [Fact]
        public void ShouldLessThanOneNotExists()
        {
            Assert.Equal(1, this.array.Min());
        }

        [Fact]
        public void ShouldGreaterThanSizeNotExists()
        {
            Assert.Equal
            (
                CreateArrayOfDistinctIntegerInRandomOrderTest.ARRAY_SIZE, 
                this.array.Max()
            );
        }

        [Fact]
        public void ShouldAllDistinct()
        {
            Assert.True(this.IsAllDistinct(this.array));
        }

        private bool IsAllDistinct(Int32[] array)
        {
            var orderedBuffer = array.OrderBy(b=>b).ToArray();

            for (var i = 0; i < orderedBuffer.Length - 1; i++)
            {
                if (orderedBuffer[i] == orderedBuffer[i + 1]) return false;
            }

            return true;
        }
    }
}
