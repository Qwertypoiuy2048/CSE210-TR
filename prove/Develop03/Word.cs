
public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public string GetWord()
    {
        string word;

        if (_hidden)
        {
            word = "____";
        }
        else
        {
            word = _word;
        }

        return word;
    }
    public void HideWord()
    {
        _hidden = true;
    }
    public void ShowWord()
    {
        _hidden = false;
    }
}