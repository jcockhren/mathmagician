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
        public void TerminalAskTheFirstQuestion()
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
        public void TerminalFirstQuestionGoodAnswer()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            string user_input = "even";
            string actual_output = term.AcceptFirstAnswer(user_input);
            string expected_output = "How many should I print?";

            // Assert
            Assert.AreEqual(expected_output, actual_output);
            Assert.AreEqual(1, term.Progress);

        }

        [TestMethod]
        public void TerminalSecondQuestionBadAnswer()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            string user_input = "1 hundred";
            string actual_output = term.AcceptSecondAnswer(user_input);
            string expected_output = "Whoops!";

            // Assert
            Assert.AreEqual(expected_output, actual_output);
            Assert.AreEqual(1, term.Progress);

        }

        [TestMethod]
        public void TerminalSecondQuestionGoodAnswer()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            string user_input = "10";
            string actual_output = term.AcceptSecondAnswer(user_input);
            string expected_output = "Cool";

            // Assert
            Assert.IsTrue(actual_output.StartsWith(expected_output));
            Assert.AreEqual(2, term.Progress);

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
