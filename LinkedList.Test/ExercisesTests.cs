using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Code4Fun;

namespace Code4Fun.Test
{
    [TestClass]
    public class ExercisesTests
    {
        [TestMethod]
        public void GetNthElementFromRightInSinglePass()
        {
            var list = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
            Assert.AreEqual("H", Exercises.GetNthElementFromRightInSinglePass(list, 1));
            Assert.AreEqual("G", Exercises.GetNthElementFromRightInSinglePass(list, 2));
            Assert.AreEqual("F", Exercises.GetNthElementFromRightInSinglePass(list, 3));
            Assert.AreEqual("E", Exercises.GetNthElementFromRightInSinglePass(list, 4));
            Assert.AreEqual("D", Exercises.GetNthElementFromRightInSinglePass(list, 5));
            Assert.AreEqual("C", Exercises.GetNthElementFromRightInSinglePass(list, 6));
            Assert.AreEqual("B", Exercises.GetNthElementFromRightInSinglePass(list, 7));
            Assert.AreEqual("A", Exercises.GetNthElementFromRightInSinglePass(list, 8));
        }
    }
}
