using System;

namespace MoogleTomeTracker.Attributes;
[AttributeUsage(AttributeTargets.Method)]
public class DoNotShowInHelpAttribute : Attribute
{
}