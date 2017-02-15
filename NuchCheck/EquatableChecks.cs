namespace Eu.Nuchs.Check
{
    using System;

    public static class EquatableChecks
    {
        public static T IsEqualTo<T>(this T target, T other, string name = "equatable")
           where T : IEquatable<T>
        {
            target.IsNotNull(name);

            return Checker.CheckExpression(
                target.Equals(other),
                $"Equality check: {name} has value \"{target}\" which is not equal to expected value of \"{other}\"",
                target);
        }

        public static T IsNotEqualTo<T>(this T target, T other, string name = "equatable")
            where T : IEquatable<T>
        {
            target.IsNotNull(name);

            return Checker.CheckExpression(
                !target.Equals(other),
                $"Inequality check: {name} has value \"{target}\" which is equal to \"{other}\" and should not be",
                target);
        }
    }
}
