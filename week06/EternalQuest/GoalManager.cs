using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Quest!\n");

        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input, please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (type == 1)
        {
            newGoal = new SimpleGoal(description, points, false, name);
        }
        else if (type == 2)
        {
            newGoal = new EternalGoal(description, points, false, name);
        }
        else if (type == 3)
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new CheckListGoal(description, points, false, name, target, bonus);
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        ListGoals();
        Console.Write("\nEnter the number of the goal you accomplished: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsEarned = _goals[goalIndex].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You now have {_score} points total!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter file name to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    private void LoadGoals()
    {
        Console.Write("Enter file name to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[1]));
            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[1]));
            else if (type == "CheckListGoal")
                _goals.Add(new CheckListGoal(parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[1], int.Parse(parts[5]), int.Parse(parts[7])));
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}
