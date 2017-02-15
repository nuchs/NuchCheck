namespace Tests
{
    using Eu.Nuchs.Check;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class BoolCheckTests
    {
        [TestMethod]
        public void TrueCheckShouldFailForFalseExpressions()
        {
            Action act = () => false.IsTrue();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void TrueCheckShouldPassForTrueExpressions()
        {
            true.IsTrue();
        }

        [TestMethod]
        public void TrueCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            bool target = false;

            Action act = () => target.IsTrue();

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(target));
        }

        [TestMethod]
        public void TrueCheckShouldReturnTrue()
        {
            var returned = true.IsTrue();

            returned.Should().BeTrue();
        }

        [TestMethod]
        public void FalseCheckShouldFailForTrueExpressions()
        {
            Action act = () => true.IsFalse();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void FalseCheckShouldPassForFalseExpressions()
        {
            false.IsFalse();
        }

        [TestMethod]
        public void FalseCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var fred = true;

            Action act = () => fred.IsFalse();

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(fred));
        }

        [TestMethod]
        public void FalseCheckShouldReturnFalse()
        {
            var returned = true.IsTrue();

            returned.Should().BeTrue();
        }
    }
}
