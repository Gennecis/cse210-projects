using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = " ";
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("what is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        if (percentage >= 90 )
        {
            letterGrade = "A";
            // Console.WriteLine($"your is {letterGrade}");
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
            // Console.WriteLine($"your is {letterGrade}");
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
            // Console.WriteLine($"your is {letterGrade}");
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"your grade is {letterGrade}");
        if (percentage >= 70)
        {
            Console.WriteLine("congrats you passed");
        }
        else
        {
            Console.WriteLine("better luck next time");
        }
    }    
}