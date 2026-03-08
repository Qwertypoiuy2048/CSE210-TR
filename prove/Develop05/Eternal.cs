public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {}
    public override void RecordEvent()
    {
        Console.WriteLine("Eternal goal recorded.");
        AddPoints();
    }
}