// Update ReflectionActivity.cs
using System;

class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity() : base("Reflection", "Reflect on times of strength and resilience.")
    {
    }

    protected override void ShowWelcomeMessage()
    {
        base.ShowWelcomeMessage();
        Console.WriteLine("Reflect on your past experiences of strength and resilience.");
    }

    protected override void PerformActivity(int duration)
    {
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Console.WriteLine("Let's begin:");

        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(8000);
            AskQuestions();
        }
    }

    private void AskQuestions()
    {
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(9000);
        }
    }
}
