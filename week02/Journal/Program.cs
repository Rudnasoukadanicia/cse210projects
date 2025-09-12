
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal Journal = new Journal();
        PromptGenerator promptGenerator1 = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("\n1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit\n");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = promptGenerator1.GetRandomPrompt();
                    Console.WriteLine(entry._promptText);
                    Console.Write("> ");
                    entry._entryText = Console.ReadLine();
                    Journal.AddEntry(entry);
                    break;
                case "2":
                    Journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    Journal.LoadFromFile(loadFilename);
                    break;
                case "4":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    Journal.SaveToFile(saveFilename);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}