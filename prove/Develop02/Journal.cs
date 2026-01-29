public class Journal
{
    public List<string> _prompts;
    public List<Entry> _entries;

    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            entry.PrintEntry();
        }
    }
}