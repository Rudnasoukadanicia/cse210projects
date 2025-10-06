using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void DisplayPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on the following questions:");
        Console.WriteLine("You may begin shortly...");
        ShowSpinner(3);
        
    }

    public void Run()
    {
        StartMessage();
        DisplayPrompt();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        Random rand = new Random();

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
        }
        EndMessage();
    }
}