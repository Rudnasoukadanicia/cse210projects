using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }
    }

    private static Random rand = new Random();
    public void HideRandomWord()
    {
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        string joinedWords = string.Join(" ", words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {joinedWords}";
    }
}