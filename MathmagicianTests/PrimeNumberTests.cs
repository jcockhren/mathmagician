using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathmagician;

namespace MathmagicianTests
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        public void PrimeEnsureICanCreateClassInstance()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            Assert.IsNotNull(Prime);
        }

        [TestMethod]
        public void PrimeShouldPrintFirstNumber()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            int expected = 2;
            int actual = Prime.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintNextNumber()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            int input = 2;
            int expected = 3;
            int actual = Prime.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeShouldPrintAVariableSequenceOfNumbers()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            int input = 8;
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            int[] actual = Prime.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimePrintSequenceOfNumbers()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            int length = 7;
            string expected = "2 3 5 7 11 13 17";
            string actual = Prime.ToString(Prime.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeFindIndexOfElement()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 73;
            int expected = 20;
            int actual = prime.FindIndex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeIsPrime()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 73;
            bool expected = true;
            bool actual = prime.IsPrime(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeIsNotPrime()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 20;
            bool expected = false;
            bool actual = prime.IsPrime(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PrimeFindIndexOfElementFails()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 103;
            prime.FindIndex(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PrimeGetNextNonPrime()
        {
            PrimeNumbers prime = new PrimeNumbers();
            int input = 105;
            prime.GetNext(input);
        }
    }
}
