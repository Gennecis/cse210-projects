using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Square square = new Square("red", 5);
        // Console.WriteLine(square.GetArea());
        // Console.WriteLine(square.GetColor());

        Rectangle rectangle = new Rectangle("blue", 5, 10);
        // Console.WriteLine(rectangle.GetArea());
        // Console.WriteLine(rectangle.GetColor());

        Circle circle = new Circle("green", 5);
        // Console.WriteLine(circle.GetArea());
        // Console.WriteLine(circle.GetColor());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.getColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}