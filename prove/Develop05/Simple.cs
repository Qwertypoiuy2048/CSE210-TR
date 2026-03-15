public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points)
    {}
    public Simple(string name, string description, int points, bool isComplete) : base(name, description, points, isComplete)
    {}
    public override int RecordEvent()
    {
        Console.WriteLine("Simple goal recorded.");
        MarkComplete();
        return AddPoints();
    }
    public override int GetType()
    {
        return 1;
    }

}
