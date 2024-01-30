using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"string: {fraction1.GetFractionString()}");
        Console.WriteLine($"decimal: {fraction1.GetDecimalValue()}");
        Console.WriteLine();
        Fraction fraction2 = new Fraction(3);
        Console.WriteLine($"string: {fraction2.GetFractionString()}");
        Console.WriteLine($"decimal: {fraction2.GetDecimalValue()}");
        Console.WriteLine();
        Fraction fraction3 = new Fraction(1,3);
        Console.WriteLine($"string: {fraction3.GetFractionString()}");
        Console.WriteLine($"decimal: {fraction3.GetDecimalValue()}");
    }
}