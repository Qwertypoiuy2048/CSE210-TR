using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        int choice = -1;
        bool looping = true;
        List<Goal> goals = new List<Goal>();
        GoalManager goalManager = new GoalManager();
        // Menu
        while (looping)
        {
            Console.WriteLine("You have 0 points.\n\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("0. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    int goalType = int.Parse(Console.ReadLine());
                    if (goalType == 1)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int pointsValue = int.Parse(Console.ReadLine());
                        Simple simpleGoal = new Simple(name, description, pointsValue);
                        goals.Add(simpleGoal);
                        goalManager.AddGoal(simpleGoal);
                    } else if (goalType == 2)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int pointsValue = int.Parse(Console.ReadLine());
                        Eternal eternalGoal = new Eternal(name, description, pointsValue);
                        goals.Add(eternalGoal);
                        goalManager.AddGoal(eternalGoal);
                    } else if (goalType == 3)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int pointsValue = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                        int timesToComplete = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the bonus for accomplishing this goal that many times? ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        Checklist checklistGoal = new Checklist(name, description, pointsValue, timesToComplete, bonusPoints);
                        goals.Add(checklistGoal);
                        goalManager.AddGoal(checklistGoal);
                    }

                    break;
                case 2:
                    Console.WriteLine("The goals are: ");
                    goalManager.DisplayGoals();

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("The goals are: ");
                    goalManager.DisplayGoals();
                    Console.WriteLine("Which goal would you like to record an event for? ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    if (goalIndex >= 0 && goalIndex < goals.Count)
                    {
                        goals[goalIndex].RecordEvent();
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal index.");
                    }

                    break;
                case 0:
                    looping = false;
                    Console.WriteLine("Thanks for using my Goal Tracker!");
                    break;
            }
        }
    }
}
