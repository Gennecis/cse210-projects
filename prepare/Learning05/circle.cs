using System;
public class Circle : Shape
{
    private int _radius;
    public Circle(string color, int radius) : base(color)
    {
        _radius = radius;
    }

    public string GetColor()
    {
        return base.getColor();
    }

    public override string GetArea()
    {
        return $"{Math.PI * _radius * _radius}";
    }
}