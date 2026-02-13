
public class Scripture
{
    Random random = new Random();
    private Ref _ref;
    private List<Word> _words;
    private int _length;
    private List<int> _hidden;
    private bool _allWordsHidden;

    public Scripture(string b, string c, string v, List<string> w)
    {
        _ref = new Ref(b,c,v);
        _words = [];
        foreach (string word in w)
        {
            _words.Add(new Word(word));
        }
        _length = _words.Count;
        _hidden = [];
        _allWordsHidden = false;
    }

    public void Display()
    {
        Console.WriteLine("\n");
        Console.Write(_ref.GetRef());
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord());
            Console.Write(' ');
        }
    }
    public void HideRandom(int num)
    {
        int hid;
        int count = 0;
        while (count < num)
        {
            
            hid = random.Next(_length);
            if (!_hidden.Contains(hid))
            {
                _words[hid].HideWord();
                count ++;
                _hidden.Add(hid);
            }
            else if (_length == _hidden.Count)
            {
                _allWordsHidden = true;
                count = num;
            }
            
        }
    }
    public bool AreWeDoneYet()
    {
        return _allWordsHidden;
    }
    public void GetHelp(int help)
    {
        int show;
        int count = 0;
        while (count < help)
        {
            
            if (_hidden.Count != 0)
            {
                show = random.Next(_hidden.Count);
                _words[_hidden[show]].ShowWord();
                count ++;
                _hidden.RemoveAt(show);
            }
            else
            {
                _allWordsHidden = false;
                count = help;
            }
            
        }

    }
}
