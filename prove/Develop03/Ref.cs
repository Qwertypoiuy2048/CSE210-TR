
public class Ref
{
    private string _book;
    private string _chapter;
    private string _verse;

    public Ref(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetRef()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}