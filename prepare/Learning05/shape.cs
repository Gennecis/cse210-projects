using System;
using System.Drawing;

public class Shape
{
    private string _color = "blue";
    public string getColor()
    {
        return _color;
    }
    public void setColor(string color)
    {
        _color = color;
    }
    public Shape(string color)
    {
        _color = color;
    }

    public virtual string GetArea()
    {
        return "";
    }
}