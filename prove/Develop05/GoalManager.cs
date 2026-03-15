public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public int GetType(int index)
    {
        return _goals[index].GetType();
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }
        Console.WriteLine("\n\n");
    }

    public int GetPoints()
    {
        return _totalPoints;
    }
    public void SetPoints(int points)
    {
        _totalPoints = points;
    }

    public void UpdatePoints(int points)
    {
        _totalPoints += points;
    }
}
