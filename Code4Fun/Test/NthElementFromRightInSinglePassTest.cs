using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Code4Fun
{
    public class NthElementFromRightInSinglePassTest
    {
        [Fact]
        public void ShouldSuccess()
        {
            var list = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
            Assert.Equal("H", Code4Fun.GetNthElementFromRightInSinglePass(list, 1));
            Assert.Equal("G", Code4Fun.GetNthElementFromRightInSinglePass(list, 2));
            Assert.Equal("F", Code4Fun.GetNthElementFromRightInSinglePass(list, 3));
            Assert.Equal("E", Code4Fun.GetNthElementFromRightInSinglePass(list, 4));
            Assert.Equal("D", Code4Fun.GetNthElementFromRightInSinglePass(list, 5));
            Assert.Equal("C", Code4Fun.GetNthElementFromRightInSinglePass(list, 6));
            Assert.Equal("B", Code4Fun.GetNthElementFromRightInSinglePass(list, 7));
            Assert.Equal("A", Code4Fun.GetNthElementFromRightInSinglePass(list, 8));
        }

        [Fact]
        public void ShouldThrownArgumentOutOfRangeExceptionIfNthElementIsGreaterThanArraySize()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () =>
            {
                Code4Fun.GetNthElementFromRightInSinglePass(new string[1], 2);
            });
        }
    }
}
