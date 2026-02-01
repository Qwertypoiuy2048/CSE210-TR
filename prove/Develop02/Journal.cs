public class Journal
{
    static Random rand = new Random();
    public List<string> _prompts;
    public List<Entry> _entries;

    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            entry.PrintEntry();
        }
    }
    public Entry WriteEntry()
    //Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
    {
        int r = rand.Next(_prompts.Count());
        string prompt = _prompts[r];
        Console.WriteLine(prompt);
        string input = Console.ReadLine();


        DateTime theCurrentTime = DateTime.Now;
        string date_now = theCurrentTime.ToShortDateString();


        Entry entry = new Entry();
        
        string _date = date_now;
        string _prompt = prompt;
        string _input = input;

        return entry;
    }
    
}
