using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        var activities = new List<ExerciseTracking.Activity>
        {
            new ExerciseTracking.Running(new DateTime(2022, 11, 3), 30, 4.8),
            new ExerciseTracking.Cycling(new DateTime(2022, 11, 3), 30, 4.8 / 1.609),
            new ExerciseTracking.Swimming(new DateTime(2023, 3, 17), 60, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}