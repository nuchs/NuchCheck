namespace Tests
{
    using Eu.Nuchs.Check;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class StringCheckTests
    {
        [TestMethod]
        public void NotEmptyCheckShouldFailForEmptyStrings()
        {
            Action act = () => string.Empty.IsNotEmpty();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotEmptyCheckShouldFailForNullStrings()
        {
            string target = null;

            Action act = () => target.IsNotEmpty();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotEmptyCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            string target = null;

            Action act = () => target.IsNotEmpty();

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(target));
        }

        [TestMethod]
        public void NotEmptyCheckShouldPassForNotEmptyStrings()
        {
            string target = "   ";

            target.IsNotEmpty();
        }

        [TestMethod]
        public void NotEmptyCheckShouldReturnTheOriginalObject()
        {
            string target = "hello";

            var returned = target.IsNotEmpty();

            returned.Should().BeSameAs(target);
        }

        [TestMethod]
        public void NotWhiteSpaceCheckShouldFailForEmptyStrings()
        {
            Action act = () => string.Empty.IsNotWhitespace();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotWhiteSpaceCheckShouldFailForNullStrings()
        {
            string target = null;

            Action act = () => target.IsNotWhitespace();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotWhiteSpaceCheckShouldFailForWhitespaceStrings()
        {
            Action act = () => "    ".IsNotWhitespace();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotWhiteSpaceCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            string target = null;

            Action act = () => target.IsNotWhitespace();

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(target));
        }

        [TestMethod]
        public void NotWhiteSpaceCheckShouldPassForNotEmptyStrings()
        {
            string target = " a b c ";

            target.IsNotWhitespace();
        }

        [TestMethod]
        public void NotWhiteSpaceCheckShouldReturnTheOriginalObject()
        {
            string target = "hello";

            var returned = target.IsNotWhitespace();

            returned.Should().BeSameAs(target);
        }
    }
}
