namespace Tests
{
    using Eu.Nuchs.Check;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class EquatableCheckTests
    {
        [TestMethod]
        public void EquatableShouldFailIfTheComparedObjectsAreNotEqual()
        {
            var target = "Hello";

            Action act = () => target.IsEqualTo("World");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void EquatableShouldFailIfTheTargetIsNull()
        {
            string target = null;

            Action act = () => target.IsEqualTo("World");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void EquatableShouldPassIfTheComparedObjectsAreEqual()
        {
            var target = 1;

            target.IsEqualTo(1);
        }

        [TestMethod]
        public void EquatableShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var target = 1;

            Action act = () => target.IsEqualTo(2);

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(target));
        }

        [TestMethod]
        public void EquatableCheckShouldReturnTheOriginalObject()
        {
            var target = "bacon";

            var returned = target.IsEqualTo("bacon");

            returned.Should().Be(target);
        }

        [TestMethod]
        public void NotEquatableShouldFailIfTheComparedObjectsAreEqual()
        {
            var target = "Hello";

            Action act = () => target.IsNotEqualTo("Hello");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void NotEquatableShouldPassIfTheComparedObjectsAreNotEqual()
        {
            var target = 1;

            target.IsNotEqualTo(2);
        }

        [TestMethod]
        public void NotEquatableShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var target = 1;

            Action act = () => target.IsNotEqualTo(1);

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(target));
        }

        [TestMethod]
        public void NotEquatableCheckShouldReturnTheOriginalObject()
        {
            var target = "egg";

            var returned = target.IsNotEqualTo("sausage");

            returned.Should().Be(target);
        }
    }
}
