
public class Scripture
{
    private Ref _ref;
    private List<Word> _words;

    public Scripture(string b, string c, string v, List<string> w)
    {
        _ref = new Ref(b,c,v);
        _words = [];
        foreach (string word in w)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Write(_ref.GetRef());
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord());
        }
    }
}
