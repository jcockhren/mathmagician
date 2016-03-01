using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddTests
    {
        [TestMethod]
        public void OddEnsureICanCreateInstance()
        {
            Odd my_odds = new Odd();
            Assert.IsNotNull(my_odds);
        }

        [TestMethod]
        public void OddEnsureICanGetFirst()
        {
            // Arrange
            Odd my_odds = new Odd();

            // Act
            int actual = my_odds.GetFirst();
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddEnsureICanGetNext()
        {
            // Arrange
            Odd my_odds = new Odd();

            // Act
            int actual = my_odds.GetNext(5);
            int expected = 7;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddIntegerEnsureICanCreateASequenceOfTen()
        {
            // Arrange
            Odd my_odds = new Odd();

            // Act
            int[] actual = my_odds.GetSequence(10);
            int[] expected = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
