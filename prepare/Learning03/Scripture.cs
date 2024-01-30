using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string reference;
    private List<ScriptureWord> words;

    public bool AllWordsHidden => words.All(w => w.IsHidden);

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        // Split the text into words
        string[] wordArray = text.Split(' ');

        // Create ScriptureWord objects for each word
        words = wordArray.Select(word => new ScriptureWord(word)).ToList();
    }

    public void HideWords()
    {
        // Hide a few words
        Random random = new Random();
        int wordsToHide = random.Next(1, 4); // hide 1 to 3 words

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);
            words[index].Hide();
        }
    }

    public string GetVisibleScripture()
    {
        // Concatenate the reference and visible words
        string visibleScripture = $"{reference}: {string.Join(" ", words.Select(w => w.IsHidden ? "___" : w.Text))}";
        return visibleScripture;
    }
}