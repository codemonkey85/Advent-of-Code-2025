// https://adventofcode.com/2025/day/1

namespace AdventOfCode.Days;

[AocExpected("1023", "")]
// ReSharper disable once UnusedType.Global
public sealed class Day01 : BaseDay
{
    private readonly string input;

    // ReSharper disable once UnusedMember.Local
    private const string TestInput =
        """
        L68
        L30
        R48
        L5
        R60
        L55
        L1
        L99
        R14
        L82
        """;

    public Day01() => input = File.ReadAllText(InputFilePath);

    public override ValueTask<string> Solve_1()
    {
        var instructions = GetInstructionsFromInput(input);

        var current = Constants.Starting;
        var count = 0;

        foreach (var instruction in instructions)
        {
            current += instruction;

            while (current is < Constants.Minimum or > Constants.Maximum)
            {
                switch (current)
                {
                    case < Constants.Minimum:
                        current += 100;
                        break;
                    case > Constants.Maximum:
                        current -= 100;
                        break;
                }
            }

            if (current == 0)
            {
                count++;
            }
        }

        return ValueTask.FromResult(count.ToString());
    }

    public override ValueTask<string> Solve_2()
    {
        var instructions = GetInstructionsFromInput(input);

        var current = Constants.Starting;
        var count = 0;

        foreach (var instruction in instructions)
        {
            var startingAtZero = current == 0;

            current += instruction;

            while (current is < Constants.Minimum or > Constants.Maximum)
            {
                switch (current)
                {
                    case < Constants.Minimum:
                        current += 100;
                        break;
                    case > Constants.Maximum:
                        current -= 100;
                        break;
                }

                if (current % 100 == 0 || !startingAtZero && current != 0)
                {
                    count++;
                }
            }

            if (current == 0)
            {
                count++;
            }
        }

        return ValueTask.FromResult(count.ToString());
    }

    private static List<int> GetInstructionsFromInput(string inputString) =>
    [
        ..
        from line in inputString.Split('\n', StringSplitOptions.RemoveEmptyEntries)
        let directionChar = line[0]
        let distance = int.Parse(line[1..])
        let value = GetDirectionFromChar(directionChar, distance)
        select value
    ];

    private static int GetDirectionFromChar(char c, int value) =>
        c switch
        {
            'R' or 'r' => value,
            'L' or 'l' => -value,
            _ => throw new ArgumentOutOfRangeException(nameof(c), c, null)
        };
}

internal static class Constants
{
    public const int Minimum = 0;
    public const int Maximum = 99;
    public const int Starting = 50;
}
