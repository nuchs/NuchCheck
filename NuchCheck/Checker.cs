namespace Eu.Nuchs.Check
{
    internal static class Checker
    {
        internal static T CheckExpression<T>(bool exp, string message, T target)
        {
            if (!exp)
            {
                throw new ValidationException(message);
            }

            return target;
        }
    }
}
