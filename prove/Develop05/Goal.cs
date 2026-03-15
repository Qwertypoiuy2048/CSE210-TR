public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    private bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public abstract int RecordEvent();
    public abstract int GetType();
    public virtual void Display()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }
    public int AddPoints()
    {
        return _points;
    }
    public void MarkComplete()
    {
        _isComplete = true;
    }


    public bool IsComplete()
    {
        return _isComplete;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual int GetTimesCompleted(){return 0;}
    public virtual int GetTargetTimes(){return 0;}
    public virtual int GetBonusPoints(){return 0;}
}
