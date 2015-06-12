using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Code4Fun
{
    public class ArrayOfDistinctIntegerInRandomOrderTest
    {
        private Int64 bufferSize = 100L;

        private Int64[] buffer ;

        public ArrayOfDistinctIntegerInRandomOrderTest()
        {
            this.buffer =
              Exercises.GetArrayOfDistinctIntegerInRandomOrder(bufferSize);
        }

        [Fact]
        public void ShouldLessThanOneNotExists()
        {
           Assert.Equal(1, this.buffer.Min());
        }

        [Fact]
        public void ShouldGreaterThanSizeNotExists()
        {
            Assert.Equal(bufferSize, this.buffer.Max());
        }


        [Fact]
        public void ShouldAllDistinct()
        {
            Assert.True(this.AllDistinct(this.buffer));
        }

        private bool AllDistinct(Int64[] buffer)
        {
            var orderedBuffer = buffer.OrderBy(b=>b).ToArray();

            for (var i = 0; i < orderedBuffer.Length - 1; i++)
            {
                if (orderedBuffer[i] == orderedBuffer[i + 1]) return false;
            }

            return true;
        }

    }
}
