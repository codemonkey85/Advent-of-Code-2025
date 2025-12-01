using System.Diagnostics.CodeAnalysis;

namespace AdventOfCode;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
public sealed class AocExpectedAttribute(string part1, string part2) : Attribute
{
    public string Part1 { get; } = part1;

    public string Part2 { get; } = part2;
}
