using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int points, bool isCompleted, string name) : base(description, points, isCompleted, name)
    {
    }

    public override int RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"\nCongratulations! You have earned {_points} points!");
        return _points;
    }
}