using System;

public class Goal
{
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    protected string _name;

    public Goal(string description, int points, bool isCompleted, string name)
    {
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
        _name = name;
    }

    public virtual int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;

        }

        return 0;
    }

    public virtual string GetDetailsString()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name}|{_description}|{_points}|{_isCompleted}";
    }

    public bool IsComplete(){
        return _isCompleted;
    }
}