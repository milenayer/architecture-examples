using OCP.Quiz.Application;

namespace OCP.Quiz.Questions;

public class MultipleChoiceQuestion : IQuestion
{
    private readonly string[] options;
    private readonly int correctOptionNumber;

    public MultipleChoiceQuestion(string prompt, string[] options, int correctOptionNumber)
    {
        if (correctOptionNumber < 1 || correctOptionNumber > options.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(correctOptionNumber));
        }

        Prompt = prompt;
        this.options = options;
        this.correctOptionNumber = correctOptionNumber;
    }

    public string Prompt { get; }

    public void ShowDetails()
    {
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }

        Console.WriteLine("Enter the option number:");
    }

    public bool IsCorrect(string answer)
    {
        return answer == correctOptionNumber.ToString();
    }
}