using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
            }
        }

        Console.WriteLine("Journal saved to file successfully!");
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    DateTime date = DateTime.Parse(reader.ReadLine());
                    string prompt = reader.ReadLine();
                    string response = reader.ReadLine();

                    entries.Add(new JournalEntry(prompt, response) { Date = date });
                }
            }

            Console.WriteLine("Journal loaded from file successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Creating a new journal.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
