namespace AdventOfCode.Days;

[AocExpected("12345", "67890")]
// ReSharper disable once UnusedType.Global
public sealed class Day01 : BaseDay
{
    private readonly string input;

    public Day01() => input = File.ReadAllText(InputFilePath);

    public override ValueTask<string> Solve_1() => ValueTask.FromResult("12345");

    public override ValueTask<string> Solve_2() => ValueTask.FromResult("67890");
}
