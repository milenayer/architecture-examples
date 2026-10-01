namespace OCP.Quiz.Application;

public interface IQuestion
{
    string Prompt { get; }

    void ShowDetails();

    bool IsCorrect(string answer);
}