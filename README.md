# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

W06 : Explain Polymorphism

Explain the meaning of Polymorphism

Polymorphism is the ability to take many forms. In programming, this principle is illustrated by the different behavior of the same line of code depending on the context. In other words, it allows a single interface to represent different underlying forms.

Highlight an advantage of polymorphism

Polymorphism gives programs greater flexibility and scalability. It allows code to be written that is compatible with objects of different classes without knowing their exact type, thus reducing code duplication and improving maintainability.

Provide an application of polymorphism

In the Eternal Quest program, we have a base class "Goal" and derived classes "SimpleGoal", "EternalGoal", and "CheckListGoal". All of these classes have the "RecordEvent()" method. When we call "RecordEvent()" on a "Goal" object, the program automatically executes the correct version of the method depending on the goal type. This is polymorphism: the same method name behaves differently for each goal type.

Code Example

using System;
using System.Collections.Generic;

//Base Class
public class Goal
{
protected string _name;
protected string _description;
protected int _points;
protected bool _isCompleted;

public Goal(string name, string description, int points, bool isCompleted)
{
_name = name;
_description = description;
_points = points;
_isCompleted = isCompleted; }

public virtual int RecordEvent()
{
if (!_isCompleted)
{
_isCompleted = true;
Console.WriteLine($"You have completed {_name} and earned {_points} points!");
return _points;
}
return 0;
}
}

// Derived class 1
public class SimpleGoal: Goal
{
public SimpleGoal(string name, string description, int points)
: base(name, description, points, false) { }

public override int RecordEvent()
{
Console.WriteLine($"Simple Goal {_name} completed! Points: {_points}");
_isCompleted = true;
return _points;
}
}

// Derived Class 2
public class EternalGoal: Goal
{
public EternalGoal(string name, string description, int points)
: base(name, description, points, false) { }

public override int RecordEvent()
{
Console.WriteLine($"Eternal Goal {_name} recorded! Points: {_points}");
return _points;
}
}

// Derived Class 3
public class CheckListGoal: Goal
{
private int _currentCount = 0;
private int _targetCount;
private int _bonusPoints;

public CheckListGoal(string name, string description, int points, int targetCount, int bonusPoints)
: base(name, description, points, false)
{
_targetCount = targetCount;
_bonusPoints = bonusPoints; }

public override int RecordEvent()
{
_currentCount++;
if (_currentCount >= _targetCount && !_isCompleted)
{
_isCompleted = true;
Console.WriteLine($"Checklist goal {_name} achieved! Points: {_points + _bonusPoints}");
return _points + _bonusPoints;
}
Console.WriteLine($"Progress on {_name}: {_currentCount}/{_targetCount} (Points: {_points})");
return _points;
}
}

// Example Usage
Program Class
{
    static void Main()
    {
    List<Goal> goals = new List<Goal>
    {
    new SimpleGoal("Read Scriptures", "Read a Chapter", 50),
    new EternalGoal("Meditate", "Daily Meditation", 20),
    new CheckListGoal("Temple Visits", "Visit the temple 5 times", 10, 5, 50)
    };

    foreach (Goal goal in goals)
    {
    goal.RecordEvent(); // Polymorphism: The same method behaves differently
    }}
}

Explain these concepts in detail

Polymorphism allows a method, such as `RecordEvent()`, to behave differently depending on the type of object it is called on. This means that the program can handle "SimpleGoal", "EternalGoal", and "CheckListGoal" objects in the same way, without knowing their exact types. Polymorphism is essential for flexibility, code reuse, and clean design in object-oriented programming.