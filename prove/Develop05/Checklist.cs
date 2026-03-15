public class Checklist : Goal
{
    private int _timesCompleted;
    private int _targetTimes;
    private int _bonusPoints;

    public Checklist(string name, string description, int points, int targetTimes, int bonusPoints) : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetTimes = targetTimes;
        _bonusPoints = bonusPoints;
    }
    public Checklist(string name, string description, int points, bool isComplete, int targetTimes, int timesCompleted, int bonusPoints) : base(name, description, points, isComplete)
    {
        _timesCompleted = 0;
        _targetTimes = targetTimes;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
    }
    public override int RecordEvent()
    {
        Console.WriteLine("Checklist goal recorded.");
        _timesCompleted++;
        if (_timesCompleted == _targetTimes)
        {
             MarkComplete();
                Console.WriteLine($"Congratulations! You've completed the checklist goal and earned a bonus of {_bonusPoints} points!");
                return AddBonusPoints();
        }
        return AddPoints();
    }

    public override void Display()
    {
        if ( IsComplete())
        {
            Console.WriteLine($"[X] { GetName()} ({ GetDescription()}) -- Completed {_timesCompleted}/{_targetTimes} times");
        }
        else
        {
            Console.WriteLine($"[ ] { GetName()} ({ GetDescription()}) -- Currently completed {_timesCompleted}/{_targetTimes} times");
        }
    }

    public int AddBonusPoints()
    {
        return _points + _bonusPoints;
    }

    public override int GetType()
    {
        return 3;
    }

    public override int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public override int GetTargetTimes()
    {
        return _targetTimes;
    }

    public override int GetBonusPoints()
    {
        return _bonusPoints;
    }
}
