
public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public Reflection(string name, string description) : base(name, description)
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Reflect()
    {
        int duration = GetDuration();
        int elapsedTime = 0;

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.Write(prompt);
        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();

        while (elapsedTime < duration)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine(question);
            Animate(6);
            elapsedTime += 6;
        }
    }
}
