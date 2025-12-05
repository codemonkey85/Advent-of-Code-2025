// https://adventofcode.com/2025/day/3

namespace AdventOfCode.Days;

[AocExpected("", "")]
// ReSharper disable once UnusedType.Global
public sealed class Day03 : BaseDay
{
    private readonly string input;

    // ReSharper disable once UnusedMember.Local
    private const string TestInput =
        """
        987654321111111
        811111111111119
        234234234234278
        818181911112111
        """;

    public Day03() => input = File.ReadAllText(InputFilePath);

    public override ValueTask<string> Solve_1() => throw new NotImplementedException();

    public override ValueTask<string> Solve_2() => throw new NotImplementedException();
}
