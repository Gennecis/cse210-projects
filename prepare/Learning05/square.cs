using System;
public class Square : Shape
{
    private int _side;
    
    public Square(string color, int side) : base(color)
    {
        _side = side;
    }

    public string GetColor()
    {
        return base.getColor();
    }

    public override string GetArea()
    {
        return $"{_side * _side}";
    }

}