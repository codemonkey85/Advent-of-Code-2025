// https://adventofcode.com/2025/day/4

namespace AdventOfCode.Days;

[AocExpected("", "")]
// ReSharper disable once UnusedType.Global
public sealed class Day04 : BaseDay
{
    private readonly string input;

    // ReSharper disable once UnusedMember.Local
    private const string TestInput1 =
        """
        ..@@.@@@@.
        @@@.@.@.@@
        @@@@@.@.@@
        @.@@@@..@.
        @@.@@@@.@@
        .@@@@@@@.@
        .@.@.@.@@@
        @.@@@.@@@@
        .@@@@@@@@.
        @.@.@@@.@.
        """;

    // ReSharper disable once UnusedMember.Local
    private const string TestInput2 =
        """
        ..xx.xx@x.
        x@@.@.@.@@
        @@@@@.x.@@
        @.@@@@..@.
        x@.@@@@.@x
        .@@@@@@@.@
        .@.@.@.@@@
        x.@@@.@@@@
        .@@@@@@@@.
        x.x.@@@.x.
        """;

    public Day04() => input = File.ReadAllText(InputFilePath);

    public override ValueTask<string> Solve_1() => throw new NotImplementedException();

    public override ValueTask<string> Solve_2() => throw new NotImplementedException();
}
