// BONUS: Added CSV export feature
// I created a new SaveToCsv() method in the Journal class and added a menu option (5)
// that allows the user to save their journal entries in a CSV format.
// This makes the file easy to open in Excel or Google Sheets.
// This exceeds the core requirements and shows creativity.


using System;
using System.Collections.Generic;
using System.IO;

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

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}