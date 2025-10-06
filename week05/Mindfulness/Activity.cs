using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int Duration => _duration;
    public virtual void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting activity: {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Get ready to begin ");
        ShowSpinner(3);
    }
    public virtual void EndMessage()
    {
        Console.WriteLine($"\nYou have completed the {_name} activity for {_duration} seconds. Well done!");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds = 3)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(200);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
    }

    public string Name => _name;
    public string Description => _description;
    
}