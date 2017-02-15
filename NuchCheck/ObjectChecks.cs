namespace Eu.Nuchs.Check
{
    public static class ObjectChecks
    {
        public static object IsNotNull(this object target, string name = "object")
        {
            return Checker.CheckExpression(
                target != null,
                $"Null check: {name} should not be null but is",
                target);
        }

        public static object IsNull(this object target, string name = "object")
        {
            return Checker.CheckExpression(
                target == null,
                $"Null check: {name} should be null but is not",
                target);
        }
    }
}
