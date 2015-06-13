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

        private readonly List<int> listOfDistinctIntegerInRandomOrder;

        public CreateArrayOfDistinctIntegerInRandomOrderTest()
        {
            this.listOfDistinctIntegerInRandomOrder = 
                Code4Fun.CreateArrayOfDistinctIntegerInRandomOrder(
                    CreateArrayOfDistinctIntegerInRandomOrderTest.ARRAY_SIZE).ToList();
        }

        [Fact]
        public void ShouldThrownExceptionIfNthElementIsNotGreaterThanOne()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () =>
            {
                Code4Fun.CreateArrayOfDistinctIntegerInRandomOrder(1).ToArray();
            });
        }

        [Fact]
        public void ShouldLessThanOneNotExists()
        {
            Assert.Equal
            (
                1, 
                this.listOfDistinctIntegerInRandomOrder.Min()
            );
        }

        [Fact]
        public void ShouldGreaterThanSizeNotExists()
        {
            Assert.Equal
            (
                CreateArrayOfDistinctIntegerInRandomOrderTest.ARRAY_SIZE, 
                this.listOfDistinctIntegerInRandomOrder.Max()
            );
        }

        [Fact]
        public void ShouldAllDistinct()
        {
            var diffChecker = new HashSet<int>();

            Assert.True
            (
                this.listOfDistinctIntegerInRandomOrder.All(
                    x => diffChecker.Add(x))
            );
        }
    }
}
