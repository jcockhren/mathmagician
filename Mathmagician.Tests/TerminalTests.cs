using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class TerminalTests
    {
        [TestMethod]
        public void TerminalEnsureICanCreateInstance()
        {
            Terminal term = new Terminal();

            Assert.IsNotNull(term);
        }

        [TestMethod]
        public void TerminalEnsureFindCorrectNumberFamily()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            string actual_output = term.AskFirstQuestion();
            string expected_output = "What would you like for me to do?";

            // Assert
            Assert.AreEqual(expected_output, actual_output);
        }

        [TestMethod]
        public void TerminalProgressStartsAtNegative()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            int actual = term.Progress;
            int expected = -1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TerminalFirstQuestionBadAnswer()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            string user_input = "car";
            string actual_output = term.AcceptFirstAnswer(user_input);
            string expected_output = "I don't know what you're talking about...";

            // Assert
            Assert.AreEqual(expected_output, actual_output);
            Assert.AreEqual(-1, term.Progress);
        }

        [TestMethod]
        public void TerminalUserNeedsHelp()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            string actual_output = term.PrintHelp();
            string expected_output = "I only understand: Even, Prime, Fibonacci, Odd and Integer";

            // Assert
            Assert.AreEqual(expected_output, actual_output);
        }
    }
}
