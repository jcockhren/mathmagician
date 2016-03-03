using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTests
    {
        [TestMethod]
        public void PrimeEnsureICanCreateInstance()
        {
            Prime my_primes = new Prime();
            Assert.IsNotNull(my_primes);
        }

        [TestMethod]
        public void PrimeEnsureICanGetFirst()
        {
            // Arrange
            Prime my_primes = new Prime();

            // Act
            int actual = my_primes.GetFirst();
            int expected = 2;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeEnsureICanGetNext()
        {
            // Arrange
            Prime my_primes = new Prime();

            // Act
            int actual = my_primes.GetNext(5);
            int expected = 7;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrimeIntegerEnsureICanCreateASequenceOfTen()
        {
            // Arrange
            Prime my_primes = new Prime();

            // Act
            int[] actual = my_primes.GetSequence(10);
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
