using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            EvenNumbers even = new EvenNumbers();
            Assert.IsNotNull(even);
        }

        [TestMethod]
        public void ShouldPrintFirstNumber()
        {
            EvenNumbers even = new EvenNumbers();
            int expected = 2;
            int actual = even.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintNextNumber()
        {
            EvenNumbers even = new EvenNumbers();
            int input = 2;
            int expected = 4;
            int actual = even.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldPrintAVariableSequenceOfNumbers()
        {
            EvenNumbers even = new EvenNumbers();
            int input = 8;
            int[] expected = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            int[] actual = even.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrintSequenceOfNumbers()
        {
            EvenNumbers even = new EvenNumbers();
            int length = 7;
            string expected = "2 4 6 8 10 12 14";
            string actual = even.ToString(even.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }


    }
}
