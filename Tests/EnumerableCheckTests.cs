namespace Tests
{
    using Eu.Nuchs.Check;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class EnumerableCheckTests
    {
        [TestMethod]
        public void NotEmptyCheckShouldFailIfTheSequenceIsEmpty()
        {
            var target = new int[0];

            Action act = () => target.IsNotEmpty();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotEmptyCheckShouldFailIfTheSequenceIsNull()
        {
            List<String> target = null;

            Action act = () => target.IsNotEmpty();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotEmptyCheckShouldPassIfTheSequenceIsNotEmpty()
        {
            var target = new List<object> { new object() };

            target.IsNotEmpty();
        }

        [TestMethod]
        public void NotEmptyCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var target = new List<char>();

            Action act = () => target.IsNotEmpty();

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(target));
        }

        [TestMethod]
        public void NotEmptyCheckCheckShouldReturnTheOriginalObject()
        {
            var target = new List<object> { new object() };

            var returned = target.IsNotEmpty();

            returned.Should().BeEquivalentTo(target);
        }
    }
}
