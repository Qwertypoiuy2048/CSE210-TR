using System;
using System.Data;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        int choice = -1;
        bool looping = true;
        string input = "";
        string filename = "DefaultFile.txt";
        GoalManager goalManager = new GoalManager();
        // Menu
        while (looping)
        {
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"\nYou have {goalManager.GetPoints()} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("0. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out int Input)) {choice = Input;} else {choice = -1;}
            switch (choice)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    input = Console.ReadLine();
                    int goalType = 0;
                    if (int.TryParse(input, out int goalInput)) {goalType = goalInput;} else {goalType = -1;}
                    if (goalType == 1)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int pointsValue = int.Parse(Console.ReadLine());
                        Simple simpleGoal = new Simple(name, description, pointsValue);
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
                        goalManager.AddGoal(checklistGoal);
                    }

                    Console.WriteLine("The goal has been added.");

                    break;
                case 2:
                    goalManager.DisplayGoals();

                    break;
                case 3:
                    Console.WriteLine("What is the name of the file you would like to save to? ");
                    filename = Console.ReadLine();
                    if (!File.Exists(filename))
                    {
                        Console.WriteLine("File does not exist.");
                        Console.WriteLine("Creating new file.");
                        File.Create(filename).Close();
                        
                    }

                    Console.WriteLine("Loading...");
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(goalManager.GetPoints());
                        
                        foreach (Goal goal in goalManager.GetGoals())
                            outputFile.WriteLine($"{goal.GetType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.IsComplete()}|{goal.GetTimesCompleted()}|{goal.GetTargetTimes()}|{goal.GetBonusPoints()}");
                    }

                    break;
                case 4:

                    Console.WriteLine("Warning! This will overwrite your current points and your goals.");
                    Console.WriteLine("Do you want to continue? (y/n) ");
                    input = Console.ReadLine();
                    if (input.ToLower() != "y") {break;}
                    goalManager.RemoveAllGoals();
                    Console.WriteLine("What is the name of the file you would like to load? ");
                    filename = Console.ReadLine();
                    if (!File.Exists(filename))
                    {
                        Console.WriteLine("File does not exist.");
                        break;
                    }

                    Console.WriteLine("Loading...");
                    
                    string[] lines = File.ReadAllLines(filename);

                    goalManager.SetPoints(int.Parse(lines[0]));
                    for (int i = 1; i < lines.Count(); i++)
                        {
                            string[] parts = lines[i].Split("|");
                            int type = int.Parse(parts[0]);
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            bool isComplete = bool.Parse(parts[4]);
                            int timesCompleted = int.Parse(parts[5]);
                            int targetTimes = int.Parse(parts[6]);
                            int bonusPoints = int.Parse(parts[7]);
                            if (type == 1)
                            {
                                Simple simpleGoal = new Simple(name, description, points, isComplete);
                                goalManager.AddGoal(simpleGoal);
                            } else if (type == 2)
                            {
                                Eternal eternalGoal = new Eternal(name, description, points, isComplete);
                                goalManager.AddGoal(eternalGoal);
                            } else if (type == 3)
                            {
                                Checklist checklistGoal = new Checklist(name, description, points, isComplete, targetTimes, timesCompleted, bonusPoints);
                                goalManager.AddGoal(checklistGoal);
                            }
                        }

                    break;
                case 5:
                    goalManager.DisplayGoals();
                    Console.WriteLine("Which goal would you like to record an event for? ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    if (goalIndex >= 0 && goalIndex < goalManager.GetGoals().Count)
                    {
                        goalManager.UpdatePoints(goalManager.GetGoals()[goalIndex].RecordEvent());
                        Console.WriteLine($"You now have {goalManager.GetPoints()} points.");
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
