using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    public EternalGoal(string description, int points, bool isCompleted, string name) : base(description, points, isCompleted, name)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"\nRecorded eternal goal! You have earned {_points} points!");
        return _points;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
}