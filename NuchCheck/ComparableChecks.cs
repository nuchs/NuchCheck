namespace Eu.Nuchs.Check
{
    using System;

    public static class ComparableChecks
    {
        public static T IsLessThan<T>(this T target, T other, string name = "comparable")
            where T : IComparable
        {
            target.IsNotNull(name);
            other.IsNotNull(nameof(other));

            return Checker.CheckExpression(
                target.CompareTo(other) < 0,
                $"Comparison Check: {name} has a value of \"{target}\" which is not less than {other}",
                target);
        }

        public static T IsLessThanOrEqualTo<T>(this T target, T other, string name = "comparable")
            where T : IComparable
        {
            target.IsNotNull(name);
            other.IsNotNull(nameof(other));

            return Checker.CheckExpression(
                target.CompareTo(other) <= 0,
                $"Comparison Check: {name} has a value of \"{target}\" which is not less than or equal to {other}",
                target);
        }

        public static T IsGreaterThan<T>(this T target, T other, string name = "comparable")
            where T : IComparable
        {
            target.IsNotNull(name);
            other.IsNotNull(nameof(other));

            return Checker.CheckExpression(
                target.CompareTo(other) > 0,
                $"Comparison Check: {name} has a value of \"{target}\" which is not greater than {other}",
                target);
        }

        public static T IsGreaterThanOrEqualTo<T>(this T target, T other, string name = "comparable")
            where T : IComparable
        {
            target.IsNotNull(name);
            other.IsNotNull(nameof(other));

            return Checker.CheckExpression(
                target.CompareTo(other) >= 0,
                $"Comparison Check: {name} has a value of \"{target}\" which is not greater than or equal to {other}",
                target);
        }

        public static T LiesBetween<T>(this T target, T lower, T upper, Range rangeType = Range.Inclusive, string name = "comparable")
            where T : IComparable
        {
            target.IsNotNull(name);
            lower.IsNotNull(nameof(lower));
            upper.IsNotNull(nameof(upper));

            switch (rangeType)
            {
                case Range.Inclusive:
                    target.IsLessThanOrEqualTo(upper, name);
                    target.IsGreaterThanOrEqualTo(lower, name);
                    break;

                case Range.UpperBoundInclusive:
                    target.IsLessThanOrEqualTo(upper, name);
                    target.IsGreaterThan(lower, name);
                    break;

                case Range.LowerBoundInclusive:
                    target.IsLessThan(upper, name);
                    target.IsGreaterThanOrEqualTo(lower, name);
                    break;

                case Range.Exclusive:
                    target.IsLessThan(upper, name);
                    target.IsGreaterThan(lower, name);
                    break;
            }

            return target;
        }
    }
}
