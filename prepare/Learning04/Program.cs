using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Colt", "Logarithm");
        // Console.WriteLine(assignment1.Getsummary());
        mathAssignment assignment2 = new mathAssignment("Colt", "logarithm", "8.5", "9-15");
        // Console.WriteLine(assignment2.GetHomeworkList());
        WritingAssignment assignment3 = new WritingAssignment("Nyma", "African History", "The Slave Trade");
        Console.WriteLine(assignment3.Getwritinginformation());
    }
}