public class Entry
{
    public string _date;
    public string _prompt;
    public string _input;

    public void PrintEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_input}\n");
    }
}
