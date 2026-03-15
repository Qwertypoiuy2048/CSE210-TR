public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {}
    public Eternal(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {}
    public override int RecordEvent()
    {
        Console.WriteLine("Eternal goal recorded.");
        return AddPoints();
    }
    public override int GetType()
    {
        return 2;
    }

}
