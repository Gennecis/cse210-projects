// Update BreathingActivity.cs
using System;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "Relax by focusing on your breathing.")
    {
    }

    protected override void ShowWelcomeMessage()
    {
        base.ShowWelcomeMessage();
        Console.WriteLine("Take a moment to breathe deeply and relax.");
    }

    protected override void PerformActivity(int duration)
    {
        Console.WriteLine("Let's begin:");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(8000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(8000);
        }
    }
}
