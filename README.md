# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

W02 : Explain Abstraction
Rudna Danicia Souka
Explain

Abstraction is the process of simplifying complex ideas. Reducing the object plays a key role. As programmers, we constantly create and use abstractions. In practice, we create public classes and methods that represent actions, while hiding internal data structures and implementation details.

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
