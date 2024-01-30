using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture object
        var scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son...");

        // Display the complete scripture
        DisplayScripture(scripture);

        // Start hiding words until all words are hidden
        while (!scripture.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide a few words
            scripture.HideWords();

            // Clear the console screen and display the updated scripture
            Console.Clear();
            DisplayScripture(scripture);
        }

        Console.WriteLine("Program ended. Press any key to exit.");
        Console.ReadKey();
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetVisibleScripture());
    }
    
}