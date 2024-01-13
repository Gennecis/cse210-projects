using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // Step 1: Generate a random number from 1 to 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        // Step 2: Initialize variables
        int userGuess;
        bool guessedCorrectly = false;

        // Step 3: Implement the game loop
        do
        {
            // Step 4: Ask the user for a guess
            Console.Write("Enter your guess: ");
            userGuess = int.Parse(Console.ReadLine());

            // Step 5: Check if the guess is correct or provide a hint
            if (userGuess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
                guessedCorrectly = true;
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Guess higher.");
            }
            else
            {
                Console.WriteLine("Too high! Guess lower.");
            }

        } while (!guessedCorrectly);

        // Step 6: End the game
        Console.WriteLine("Game over. Thanks for playing!");
    }
}