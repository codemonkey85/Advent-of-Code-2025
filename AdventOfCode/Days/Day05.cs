// https://adventofcode.com/2025/day/5

namespace AdventOfCode.Days;

[AocExpected("", "")]
// ReSharper disable once UnusedType.Global
public sealed class Day05 : BaseDay
{
    private readonly string input;

    // ReSharper disable once UnusedMember.Local
    private const string TestInput =
        """
        3-5
        10-14
        16-20
        12-18

        1
        5
        8
        11
        17
        32
        """;

    public Day05() => input = File.ReadAllText(InputFilePath);

    public override ValueTask<string> Solve_1() => throw new NotImplementedException();

    public override ValueTask<string> Solve_2() => throw new NotImplementedException();
}
