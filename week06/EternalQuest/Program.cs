using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        Console.WriteLine("Welcome to the Eternal Quest!");
        GoalManager goalManager = new GoalManager();
    
        goalManager.Start();
    }
}