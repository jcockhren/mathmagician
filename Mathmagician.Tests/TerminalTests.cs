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
            string expected_output = "Whoops!";

            // Assert
            Assert.AreEqual(expected_output, actual_output);
            Assert.AreEqual(0, term.Progress);
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
            Assert.AreEqual(user_input, term.NumberFamily);
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
            Assert.AreEqual(10, term.Count);
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

        [TestMethod]
        public void TerminalHappyPathPrimeNumbers()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            term.AskFirstQuestion();
            string first_input = "prime";
            term.AcceptFirstAnswer(first_input); /* Create Prime class instance */
            string second_input = "20";
            string second_output = term.AcceptSecondAnswer(second_input);
            string expected_second_output = "Cool. I'm going to print 20 prime numbers";

            // Assert
            Assert.AreEqual(expected_second_output, second_output);
            Assert.AreEqual(2, term.Progress);
            Assert.AreEqual(first_input,term.NumberFamily);
            Assert.AreEqual(20, term.Count);

        }

        [TestMethod]
        public void TerminalFirstQuestionSadPathPrimeNumbers()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            term.AskFirstQuestion();
            string first_input = "car";
            string actual_output = term.AcceptFirstAnswer(first_input);
            string expected_output = "Whoops!";

            // Assert
            Assert.AreEqual(expected_output, actual_output);
            Assert.AreEqual(0, term.Progress);
            Assert.IsNull(term.NumberFamily);
            Assert.AreEqual(0, term.Count);

        }

        [TestMethod]
        public void TerminalSecondQuestionSadPathPrimeNumbers()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            term.AskFirstQuestion();
            string first_input = "prime";
            term.AcceptFirstAnswer(first_input);
            string second_input = "2000";
            string second_output = term.AcceptSecondAnswer(second_input);
            string expected_second_output = "Whoops!";

            // Assert
            Assert.AreEqual(expected_second_output, second_output);
            Assert.AreEqual(1, term.Progress);
            Assert.AreEqual(first_input, term.NumberFamily);
            Assert.AreEqual(0,term.Count);

        }

        [TestMethod]
        public void TerminalInstantiatePrimeInstance()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act 
            term.AskFirstQuestion();
            string first_input = "prime";
            term.AcceptFirstAnswer(first_input);
            Integer actual_output = term.NumberFamilyFactory();

            // Assert
            Assert.IsInstanceOfType(actual_output, typeof(Prime));
        }

        [TestMethod]
        public void TerminalPrintSequenceOfNumbers()
        {
            // Arrange
            Terminal term = new Terminal();

            // Act
            string class_type = "integer";
            term.AcceptFirstAnswer(class_type); /* Create Prime class instance */
            string how_many = "10";
            string second_output = term.AcceptSecondAnswer(how_many);
            string actual_output = term.PrintSequence();
            string expected_output = "0 1 2 3 4 5 6 7 8 9";

            // Assert
            Assert.AreEqual(expected_output, actual_output);
        }
    }
}
