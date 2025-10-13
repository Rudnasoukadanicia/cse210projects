# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

W05 : Explain Inheritance

Explain the meaning of Inheritance:

Inheritance is the ability for me class to obtain the attributes and methods of another class directly .It follows the same idea of people inheriting certain characteristices from their 

Highlight a benefit of Inheritance:

Inheritance allows a class to reuse or inherit code from another class, thus reducing duplication and simplifying program maintenance. It also allows for organization. Shared behaviors and attributes can be placed in a base class. Finally, it makes programs more flexible because new classes can be created by extending existing classes without modifying the original code.

Provide an application of Inheritance:

In the Mindfulness Week program, we can use a base class called Activity, with shared attributes like Name, Description, and Duration, as well as shared methods like StartMessage() and EndMessage(). Then we create derived classes, such as BreathingActivity, ReflectingActivity, and ListingActivity, that inherit from Activity. Each derived class can have its own behavior, while still reusing Activity's shared code.

Example Code :

Here is some sample code from the program that illustrates inheritance

using System;

public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Starting {Name} for {Duration} seconds...");
    }

    public void EndMessage()
    {
        Console.WriteLine($"You have completed {Name}. Well done!");
    }
}

// Derived class
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        StartMessage();
        Console.WriteLine("Breathe in...");
        Console.WriteLine("Breathe out...");
        EndMessage();
    }
}

// Example usage
class Program
{
    static void Main()
    {
        BreathingActivity breathing = new BreathingActivity(
            "Breathing Activity",
            "Helps you relax by focusing on breathing slowly.",
            10
        );

        breathing.Run();
    }
}

Thoroughly explain these concepts:

Inheritance is a fundamental principle of object-oriented programming that allows one class to reuse the attributes and methods of another class. The class that provides the behaviors is called the base class or superclass, while the class that inherits is called the derived class or subclass. Inheritance reduces code duplication, facilitates maintenance, and allows for more flexible programs. Inheritance is a powerful principle that can save many hours of coding.

W06 : Explain Polymorphism

Explain the meaning of Polymorphism

Polymorphism is the ability to take on many forms