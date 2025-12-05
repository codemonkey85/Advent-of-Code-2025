// https://adventofcode.com/2025/day/2

namespace AdventOfCode.Days;

[AocExpected("", "")]
// ReSharper disable once UnusedType.Global
public sealed class Day02 : BaseDay
{
    private readonly string input;

    // ReSharper disable once UnusedMember.Local
    private const string TestInput =
        """
        11-22,95-115,998-1012,1188511880-1188511890,222220-222224,
        1698522-1698528,446443-446449,38593856-38593862,565653-565659,
        824824821-824824827,2121212118-2121212124
        """;

    public Day02() => input = File.ReadAllText(InputFilePath);

    public override ValueTask<string> Solve_1() => throw new NotImplementedException();

    public override ValueTask<string> Solve_2() => throw new NotImplementedException();
}
