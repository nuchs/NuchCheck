namespace Tests
{
    using Eu.Nuchs.Check;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class ObjectCheckTests
    {
        [TestMethod]
        public void NotNullCheckShouldFailForNullObjects()
        {
            object target = null;

            Action act = () => target.IsNotNull();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotNullCheckShouldPassForNonNullObjects()
        {
            var target = new object();

            target.IsNotNull();
        }

        [TestMethod]
        public void NotNullCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            object target = null;

            Action act = () => target.IsNotNull();

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(target));
        }

        [TestMethod]
        public void NotNullCheckShouldReturnTheOriginalObject()
        {
            var target = new object();

            var returned = target.IsNotNull();

            returned.Should().BeSameAs(target);
        }

        [TestMethod]
        public void NullCheckShouldFailForNonNullObjects()
        {
            var target = new object();

            Action act = () => target.IsNull();

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NullCheckShouldPassForNullObjects()
        {
            object target = null;

            target.IsNull();
        }

        [TestMethod]
        public void NullCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var target = new object();

            Action act = () => target.IsNull();

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(target));
        }

        [TestMethod]
        public void NullCheckShouldReturnTheOriginalObject()
        {
            object target = null;

            var returned = target.IsNull();

            returned.Should().BeSameAs(target);
        }
    }
}
