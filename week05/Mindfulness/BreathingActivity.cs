using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in");
            ShowSpinner(3);
            Console.WriteLine("Breathe out");
            ShowSpinner(3);
        }
        
        Console.WriteLine();
        EndMessage();
    }
}