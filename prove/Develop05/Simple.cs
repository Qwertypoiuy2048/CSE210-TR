public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points)
    {}
    public override void RecordEvent()
    {
        Console.WriteLine("Simple goal recorded.");
        MarkComplete();
        AddPoints();
    }
}
