namespace OCP.Quiz.Application;

public class QuizRunner
{
    public void Run(IEnumerable<IQuestion> questions)
    {
        int score = 0;
        int total = 0;

        foreach (var question in questions)
        {
            total++;
            Console.WriteLine(question.Prompt);
            question.ShowDetails();

            string answer = (Console.ReadLine() ?? "").Trim();
            bool correct = question.IsCorrect(answer);

            if (correct)
            {
                score++;
            }

            Console.WriteLine(correct ? "Correct!" : "Incorrect.");
        }

        Console.WriteLine($"Score: {score}/{total}");
    }
}