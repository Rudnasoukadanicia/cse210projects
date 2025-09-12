# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

This repository contains the starter code for many different projects. They are arranged folders by week. There is also an an empty sandbox project that can be used to play around with any concept you would like.

Rudna Danicia Souka

Version Control – Explain:

Version control is a system that tracks changes made to a file or folder. It's important because it allows you to identify and correct errors in your code and collaborate effectively.

Highlight a benefit:

Version control allows collaboration between multiple developers without overwriting each other's work. It also improves reliability, productivity, and efficient software development.

Example of version control:

For example, within a team, everyone may be working on different code, but with version control, everyone's changes are known to everyone.

A command is:

git commit -m "Added login feature"
 

Thoroughly explain these concepts :

Version control is a system that allows you to track, manage, and record changes made to project files, typically in software development. Its strength is that it records changes at any time, meaning that each change can be viewed by another programmer, corrected, or compared to previous versions using commit messages. In the event of an error, it is possible to revert to a previous version without losing any work, which significantly improves the security and reliability of the project.
Version control also facilitates collaboration. This means that multiple developers can work simultaneously on different parts of the same project without disrupting each other's work.


W02 : Explain Abstraction

Explain

Abstraction allows object-oriented roles. In practice, we create public classes and methods that represent actions, while hiding internal data structures and implementation details.

Benefits

One of the main advantages of abstraction is coupling, meaning that the code that uses a class depends only on its public interface.

Application

I'll take this week's project as an example. In my program, responsibility is divided into small classes:

Entry — Represents a single log entry and knows how to display it.

Journal — Stores entries and provides methods for adding, displaying, saving, and loading.

PromptGenerator — Contains the prompt data and exposes a method to return a random prompt.

Since each class only exposes a few public methods, the Program class can operate at a high level, such as creating a prompt, adding an entry, and saving.

Code examples (demonstrating abstraction)

Log hides the list and exposes simple operations:

public class Journal
{
private List<Entry> _entries = new List<Entry>();

public void AddEntry(Entry entry)
{
_entries.Add(entry);
}

public void DisplayAll()
{
foreach (Entry entry in _entries)
{
entry.Display();
}
}

public void SaveToFile(string filename) { /* File logic hidden here */ }
public void LoadFromFile(string filename) { /* Parsing hidden here */ }
}


PromptGenerator hides the prompt storage and only exposes GetRandomPrompt():


public class PromptGenerator
{
private List<string> _prompts = new List<string>();

public PromptGenerator()
{
_prompts.Add("Who did I interact with most interestingly today?"); // ...
}

public string GetRandomPrompt()
{
return _prompts[new Random().Next(_prompts.Count)];
}
}


The Program uses these public methods and never directly manipulates _entries:


Journal journal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();

Entry newEntry = new Entry();
newEntry._date = DateTime.Now.ToShortDateString();
newEntry._promptText = promptGenerator.GetRandomPrompt();
newEntry._entryText = Console.ReadLine();
journal.AddEntry(newEntry); // The program doesn't care how the Journal stores entries


Explain these concepts

The code demonstrates abstraction by separating responsibilities and exposing small, relevant APIs. One improvement to strengthen abstraction is to encapsulate data fields. This prevents external code from directly modifying internal state, thus preserving the class contract.
So abstraction simplifies how other code interacts with a component, makes it easier to modify and reason about our program, and is clearly enforced in the Journal program by the "Journal", "Entry", and "PromptGenerator" classes.
