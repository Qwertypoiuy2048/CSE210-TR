
public class Listing : Activity
{
    private List<string> _prompts;
    private Random _random;

    public Listing(string name, string description) : base(name, description)
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void List()
    {
        int duration = GetDuration();
        string prompt = _prompts[_random.Next(_prompts.Count)];
        
        Console.WriteLine(prompt);
        Console.Write("You have a few seconds to think about this... ");
        Animate(5);
        
        Console.WriteLine("Start listing items (press Enter after each item):");
        
        int itemCount = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"\nYou listed {itemCount} items!");
    }
}
