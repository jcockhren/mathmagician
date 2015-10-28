using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class FibonacciNumberTests
    {
        [TestMethod]
        public void FibonacciEnsureICanCreateClassInstance()
        {
            FibonacciNumbers fibo = new FibonacciNumbers();
            Assert.IsNotNull(fibo);
        }

        [TestMethod]
        public void FibonacciShouldPrintFirstNumber()
        {
            FibonacciNumbers Fibonacci = new FibonacciNumbers();
            int expected = 1;
            int actual = Fibonacci.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // Take another look
        public void FibonacciShouldPrintNextNumber()
        {
            FibonacciNumbers Fibonacci = new FibonacciNumbers();
            int input = 3;
            int expected = 5;
            int actual = Fibonacci.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciShouldPrintAVariableSequenceOfNumbers()
        {
            FibonacciNumbers Fibonacci = new FibonacciNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21 };
            int[] actual = Fibonacci.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciPrintSequenceOfNumbers()
        {
            FibonacciNumbers Fibonacci = new FibonacciNumbers();
            int length = 7;
            string expected = "1 1 2 3 5 8 13";
            string actual = Fibonacci.ToString(Fibonacci.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
