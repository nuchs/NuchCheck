namespace Tests
{
    using Eu.Nuchs.Check;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class ComparableCheckTests
    {
        [TestMethod]
        public void LessThanCheckShouldFailIfTheTargetIsNotLessThanTheBound()
        {
            var target = 1;

            Action act = () => target.IsLessThan(1);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LessThanCheckShouldFailIfTheTargetIsNull()
        {
            string target = null;

            Action act = () => target.IsLessThan("a");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LessThanCheckShouldFailIfTheBoundIsNull()
        {
            var target = "a";

            Action act = () => target.IsLessThan(null);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LessThanCheckShouldPassIfTheTargetIsLessThanTheBound()
        {
            var target = 2.0;

            target.IsLessThan(3.0);
        }

        [TestMethod]
        public void LessThanCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var eric = 'b';

            Action act = () => eric.IsLessThan('a');

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(eric));
        }

        [TestMethod]
        public void LessThanCheckCheckShouldReturnTheOriginalObject()
        {
            var target = 10;

            var returned = target.IsLessThan(20);

            returned.Should().Be(target);
        }

        [TestMethod]
        public void LessThanOrEqualToCheckShouldFailIfTheTargetIsNotLessOrEqualToThanTheBound()
        {
            var target = 1;

            Action act = () => target.IsLessThanOrEqualTo(0);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LessThanOrEqualToCheckShouldFailIfTheTargetIsNull()
        {
            string target = null;

            Action act = () => target.IsLessThanOrEqualTo("a");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LessThanOrEqualToCheckShouldFailIfTheBoundIsNull()
        {
            var target = "a";

            Action act = () => target.IsLessThanOrEqualTo(null);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LessThanOrEqualToCheckShouldPassIfTheTargetIsLessThanTheBound()
        {
            var target = 2.0;

            target.IsLessThanOrEqualTo(3.0);
        }

        [TestMethod]
        public void LessThanOrEqualToCheckShouldPassIfTheTargetIsEqualToTheBound()
        {
            var target = 2;

            target.IsLessThanOrEqualTo(2);
        }

        [TestMethod]
        public void LessThanOrEqualToCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var eric = 'b';

            Action act = () => eric.IsLessThanOrEqualTo('a');

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(eric));
        }

        [TestMethod]
        public void LessThanOrEqualToCheckCheckShouldReturnTheOriginalObject()
        {
            var target = 10;

            var returned = target.IsLessThanOrEqualTo(20);

            returned.Should().Be(target);
        }

        [TestMethod]
        public void GreaterThanCheckShouldFailIfTheTargetIsNotGreaterThanTheBound()
        {
            var target = 1;

            Action act = () => target.IsGreaterThan(1);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void GreaterThanCheckShouldFailIfTheTargetIsNull()
        {
            string target = null;

            Action act = () => target.IsGreaterThan("a");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void GreaterThanCheckShouldFailIfTheBoundIsNull()
        {
            var target = "a";

            Action act = () => target.IsGreaterThan(null);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void GreaterThanCheckShouldPassIfTheTargetIsGreaterThanTheBound()
        {
            var target = 4.0;

            target.IsGreaterThan(3.0);
        }

        [TestMethod]
        public void GreaterThanCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var eric = 'b';

            Action act = () => eric.IsGreaterThan('c');

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(eric));
        }

        [TestMethod]
        public void GreaterThanCheckCheckShouldReturnTheOriginalObject()
        {
            var target = 10;

            var returned = target.IsGreaterThan(5);

            returned.Should().Be(target);
        }

        [TestMethod]
        public void GreaterThanOrEqualToCheckShouldFailIfTheTargetIsNotGreaterOrEqualToThanTheBound()
        {
            var target = 1;

            Action act = () => target.IsGreaterThanOrEqualTo(2);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void GreaterThanOrEqualToCheckShouldFailIfTheTargetIsNull()
        {
            string target = null;

            Action act = () => target.IsGreaterThanOrEqualTo("a");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void GreaterThanOrEqualToCheckShouldFailIfTheBoundIsNull()
        {
            var target = "a";

            Action act = () => target.IsGreaterThanOrEqualTo(null);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void GreaterThanOrEqualToCheckShouldPassIfTheTargetIsGreaterThanTheBound()
        {
            var target = 4.0;

            target.IsGreaterThanOrEqualTo(3.0);
        }

        [TestMethod]
        public void GreaterThanOrEqualToCheckShouldPassIfTheTargetIsEqualToTheBound()
        {
            var target = 3;

            target.IsGreaterThanOrEqualTo(3);
        }

        [TestMethod]
        public void GreaterThanOrEqualToCheckShouldIncludeAProvidedNameInTheErrorMessage()
        {
            var eric = 'b';

            Action act = () => eric.IsGreaterThanOrEqualTo('c');

            act.ShouldThrow<ValidationException>().Which.Message.Contains(nameof(eric));
        }

        [TestMethod]
        public void GreaterThanOrEqualToCheckCheckShouldReturnTheOriginalObject()
        {
            var target = 30;

            var returned = target.IsGreaterThanOrEqualTo(20);

            returned.Should().Be(target);
        }

        [TestMethod]
        public void LiesBetweenCheckShouldFailIfTheTargetIsNull()
        {
            string target = null;

            Action act = () => target.LiesBetween("a", "c");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LiesBetweenCheckShouldFailIfTheLowerBoundIsNull()
        {
            var target = "b";

            Action act = () => target.LiesBetween(null, "c");

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LiesBetweenCheckShouldFailIfTheUpperBoundIsNull()
        {
            var target = "b";

            Action act = () => target.LiesBetween("a", null);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LiesBetweenCheckShouldPassIfTargetIsLessThanUpperBoundAndGreaterThanLowerBound()
        {
            var target = 2;

            target.LiesBetween(1, 3);
        }

        [TestMethod]
        public void LiesBetweenCheckShouldFailIfTargetIsLessThanLowerBound()
        {
            var target = 0;

            Action act = () => target.LiesBetween(1, 3);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LiesBetweenCheckShouldFailIfTargetIsGreaterThanUpperBound()
        {
            var target = 4;

            Action act = () => target.LiesBetween(1, 3);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void InclusiveLiesBetweenCheckShouldPassIfTargetIsEqualToUpperBound()
        {
            var target = 3;

            target.LiesBetween(1, 3);
        }

        [TestMethod]
        public void InclusiveLiesBetweenCheckShouldPassIfTargetIsEqualToLowerBound()
        {
            var target = 1;

            target.LiesBetween(1, 3);
        }

        [TestMethod]
        public void UpperBoundInclusiveLiesBetweenCheckShouldPassIfTargetIsEqualToUpperBound()
        {
            var target = 3;

            target.LiesBetween(1, 3, Range.UpperBoundInclusive);
        }

        [TestMethod]
        public void UpperBoundInclusiveLiesBetweenCheckShouldFailIfTargetIsEqualToLowerBound()
        {
            var target = 1;

            Action act = () => target.LiesBetween(1, 3, Range.UpperBoundInclusive);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void LowerBoundInclusiveLiesBetweenCheckShouldPassIfTargetIsEqualToLowerBound()
        {
            var target = 1;

            target.LiesBetween(1, 3, Range.LowerBoundInclusive);
        }

        [TestMethod]
        public void LowerBoundInclusiveLiesBetweenCheckShouldFailIfTargetIsEqualToUpperBound()
        {
            var target = 3;

            Action act = () => target.LiesBetween(1, 3, Range.LowerBoundInclusive);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void ExclusiveLiesBetweenCheckShouldFailIfTargetIsEqualToLowerBound()
        {
            var target = 1;

            Action act = () => target.LiesBetween(1, 3, Range.Exclusive);

            act.ShouldThrow<ValidationException>();
        }

        [TestMethod]
        public void ExclusiveLiesBetweenCheckShouldFailIfTargetIsEqualToUpperBound()
        {
            var target = 3;

            Action act = () => target.LiesBetween(1, 3, Range.Exclusive);

            act.ShouldThrow<ValidationException>();
        }
    }
}
