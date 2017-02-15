namespace Eu.Nuchs.Check
{
    public static class StringChecks
    {
        public static string IsNotEmpty(this string target, string name = "string")
        {
            return Checker.CheckExpression(
               !string.IsNullOrEmpty(target),
               $"String Check: {name} is null or empty and should not be",
               target);
        }

        public static string IsNotWhitespace(this string target, string name = "string")
        {
            return Checker.CheckExpression(
               !string.IsNullOrWhiteSpace(target),
               $"String Check: {name} is null, empty or whitespace and should not be",
               target);
        }
    }
}
