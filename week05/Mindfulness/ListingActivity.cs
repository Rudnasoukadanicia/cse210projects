using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity: Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "When have you felt the Holy Ghost recently?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"-- {prompt} --\n");

        Console.WriteLine("You may begin listing in a moment...");

        ShowSpinner(3);

        Console.WriteLine("Start listing now!");
        
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string answers = Console.ReadLine();
            responses.Add(answers);

        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        EndMessage();
    }
    
}