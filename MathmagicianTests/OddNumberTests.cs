using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void OddEnsureICanCreateClassInstance()
        {
            OddNumbers Odd = new OddNumbers();
            Assert.IsNotNull(Odd);
        }

        [TestMethod]
        public void OddShouldPrintFirstNumber()
        {
            OddNumbers Odd = new OddNumbers();
            int expected = 1;
            int actual = Odd.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintNextNumber()
        {
            OddNumbers Odd = new OddNumbers();
            int input = 1;
            int expected = 3;
            int actual = Odd.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddShouldPrintAVariableSequenceOfNumbers()
        {
            OddNumbers Odd = new OddNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
            int[] actual = Odd.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddPrintSequenceOfNumbers()
        {
            OddNumbers Odd = new OddNumbers();
            int length = 7;
            string expected = "1 3 5 7 9 11 13";
            string actual = Odd.ToString(Odd.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

    }
}