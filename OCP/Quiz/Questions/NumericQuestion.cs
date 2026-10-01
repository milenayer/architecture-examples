using System.Globalization;
using OCP.Quiz.Application;

namespace OCP.Quiz.Questions;

public class NumericQuestion : IQuestion
{
    private readonly decimal expected;
    private readonly decimal tolerance;

    public NumericQuestion(string prompt, decimal expected, decimal tolerance)
    {
        if (tolerance < 0m)
        {
            throw new ArgumentOutOfRangeException(nameof(tolerance), "Tolerance cannot be negative.");
        }

        Prompt = prompt;
        this.expected = expected;
        this.tolerance = tolerance;
    }

    public string Prompt { get; }

    public void ShowDetails()
    {
        Console.WriteLine("Enter a number:");
    }

    public bool IsCorrect(string answer)
    {
        if (!decimal.TryParse(answer, NumberStyles.Number, CultureInfo.InvariantCulture, out var value))
        {
            return false;
        }

        return Math.Abs(value - expected) <= tolerance;
    }
}