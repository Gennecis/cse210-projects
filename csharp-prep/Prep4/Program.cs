using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        // Step 1: Ask the user for a series of numbers and append to a list
        Console.WriteLine("Enter a series of numbers. Enter 0 to stop.");

        int userInput;
        int sum = 0;
        int count = 0;
        int maxNumber = int.MinValue;

        do
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                // Accumulate sum
                sum += userInput;

                // Count numbers
                count++;

                // Track maximum number
                if (userInput > maxNumber)
                {
                    maxNumber = userInput;
                }
            }

        } while (userInput != 0);

        // Step 2: Compute the average of the numbers in the list
        double average = count > 0 ? (double)sum / count : 0;

        // Step 3: Display the results
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum Number: {maxNumber}");
    }
}