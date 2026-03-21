// =========================
// Surge Manager
// =========================
using System.Reflection.Metadata;

class SurgeManager
{
    private SurgeTable _surges;
    private List<Surge> _history;
    private List<char> _types;
    private List<int> _powers;
    private Constant _default; 
    private int _historyLength;

    public SurgeManager(SurgeTable table, int historyLength)
    {
        _surges = table;
        _history = new List<Surge>();
        _types = new List<char> {'B', 'V', 'H'};
        _powers = new List<int> {1,2,3,4};
        _default = new Constant(0, 'B', 1, "No surges were found. Please try again.");
        _historyLength = historyLength;
    }

    public Surge GetSurge()
    {
        Surge surge = _surges.GetSurge();
        if (surge == null) return _default;
        if (_history.Contains(surge)) return GetSurge();

        // TODO: ask if good
        surge.DisplayDetails();
        if (Console.ReadLine() != "") return GetSurge();

        _history.Add(surge);
        return surge;
    }

    public Surge GetFilteredSurge(List<char> types, List<int> powers)
    {
        List<Surge> filtered = _surges.FilterSurge(types, powers);

        if (filtered.Count == 0) return _default;

        Random rand = new Random();
        Surge surge = filtered[rand.Next(filtered.Count)];
        if (_history.Contains(surge)) return GetFilteredSurge(types, powers);

        surge.DisplayDetails();
        if (Console.ReadLine() != "") return GetFilteredSurge(types, powers);
        _history.Add(surge);
        return surge;
    }

    public void CheckHistory()
    {
        if (_history.Count > _historyLength) _history.RemoveAt(0);
    }
}

