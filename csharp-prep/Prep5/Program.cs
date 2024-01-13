using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        // Call the functions and store the return values
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        // Display the welcome message
        DisplayWelcome();

        // Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt user for their name
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello, {name}! Your favorite number squared is: {squaredNumber}");
    }
}