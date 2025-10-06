using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Program ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choise = Console.ReadLine();

            if (choise == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Write("\nEnter the duration in seconds: ");

            int duration = int.Parse(Console.ReadLine());

            switch (choise)

            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration);

                    breathing.Run();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity(
                        "Reflecting Activity",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                        duration);

                    reflecting.StartMessage();
                    reflecting.DisplayPrompt();
                    reflecting.ShowSpinner(3);
                    reflecting.EndMessage();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity(
                        "Listing Activity",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                        duration);
                    listing.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }
    }
}