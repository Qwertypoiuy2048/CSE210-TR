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
    public override void RecordEvent()
    {
        Console.WriteLine("Checklist goal recorded.");
        _timesCompleted++;
        AddPoints();
        if (_timesCompleted >= _targetTimes)
        {
             MarkComplete();
                Console.WriteLine($"Congratulations! You've completed the checklist goal and earned a bonus of {_bonusPoints} points!");
                AddPoints();
        }
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
}
