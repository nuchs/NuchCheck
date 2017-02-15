namespace Eu.Nuchs.Check
{
    using System.Collections.Generic;
    using System.Linq;

    public static class EnumerableChecks
    {
        public static IEnumerable<T> IsNotEmpty<T>(this IEnumerable<T> target, string name = "enumerable")
        {
            target.IsNotNull(name);

            return Checker.CheckExpression(
                target.Count() > 0,
                $"Enumerable Check: {name} is empty and should not be",
                target);
        }
    }
}
