
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Prepare Thy Self...  ");
        Animate(3);
    }

    public void End()
    {
        Console.WriteLine("Good job!");
        Animate(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Animate(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Animate(int time)
    {
        for (int i = 0; i < time; i++)
        {
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
        }
        Console.Write("\b \n");
    }
}
