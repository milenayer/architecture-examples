using OCP.Quiz.Application;

namespace OCP.Quiz.Questions;

public class TextQuestion : IQuestion
{
    private readonly string correctAnswer;

    public TextQuestion(string prompt, string correctAnswer)
    {
        Prompt = prompt;
        this.correctAnswer = correctAnswer;
    }

    public string Prompt { get; }

    public void ShowDetails()
    {
        Console.WriteLine("Type your answer:");
    }

    public bool IsCorrect(string answer)
    {
        return answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase);
    }
}