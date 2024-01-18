using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2027;
        job1._endYear = 2032;
        job1.Display();
        // Console.WriteLine($"first job: {job1.DisplayJob()}");
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2032;
        job2._endYear = 2040;
        job2.Display();
        // Console.WriteLine($"second job: {job2.Display()}");

        Resume myResume = new Resume();
        myResume._name = "Pascal";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();



        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string randomPrompt = prompts[random.Next(prompts.Count)];
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(new JournalEntry(randomPrompt, response));
                    break;

                case 2:
                    journal.DisplayJournal();
                    break;

                case 3:
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case 4:
                    Console.Write("Enter the filename to load the journal: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}