using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EvenEnsureICanCreateInstance()
        {
            Even my_evens = new Even();
            Assert.IsNotNull(my_evens);
        }

        [TestMethod]
        public void EvenEnsureICanGetFirst()
        {
            // Arrange
            Even my_evens = new Even();

            // Act
            int actual = my_evens.GetFirst();
            int expected = 2;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvenEnsureICanGetNext()
        {
            // Arrange
            Even my_evens = new Even();

            // Act
            int actual = my_evens.GetNext(6);
            int expected = 8;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvenIntegerEnsureICanCreateASequenceOfTen()
        {
            // Arrange
            Even my_evens = new Even();
            
            // Act
            int[] actual = my_evens.GetSequence(10);
            int[] expected = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
