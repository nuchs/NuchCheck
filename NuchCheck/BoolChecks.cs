namespace Eu.Nuchs.Check
{
    public static class BoolChecks
    {
        public static bool IsTrue(this bool target, string name = "boolean expression")
        {
            return Checker.CheckExpression(
                target,
                $"Boolean check: {name} should be true but is false",
                target);
        }

        public static bool IsFalse(this bool target, string name = "boolean expression")
        {
            return Checker.CheckExpression(
                !target,
                $"Boolean check: {name} should be false but is true",
                target);
        }
    }
}
