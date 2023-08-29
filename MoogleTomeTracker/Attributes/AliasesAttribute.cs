using System;

namespace MoogleTomeTracker.Attributes;
[AttributeUsage(AttributeTargets.Method)]
public class AliasesAttribute : Attribute
{
    public string[] Aliases { get; }

    public AliasesAttribute(params string[] aliases)
    {
        Aliases = aliases;
    }
}
