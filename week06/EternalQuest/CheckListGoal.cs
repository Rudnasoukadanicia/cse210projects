using System;
using System.Collections.Generic;

public class CheckListGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public CheckListGoal(string description, int points, bool isCompleted, string name, int targetCount, int bonusPoints)
        : base(description, points, isCompleted, name)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            if (!_isCompleted)
            {
                _isCompleted = true;
                Console.WriteLine($"Goal completed! You earned {_bonusPoints + _points} points!");
                return _bonusPoints + _points;
            }
            else
            {
                Console.WriteLine($"Progress: {_currentCount}/{_targetCount}. You earned {_points} points!");
                return _points;
            }
        }
        else
        {
            Console.WriteLine($"\nProgress recorded! You have earned {_points} points. {_targetCount - _currentCount} more to complete the goal.");
            return _points;
        }
    }

    public override string GetDetailsString()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
    }
    
    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_description}|{_points}|{_isCompleted}|{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
    
}