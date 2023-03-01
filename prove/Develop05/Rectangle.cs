using System;

public class Rectangle: Shape
{
    private class _length;
    private class _width;

    public Rectangle(string color, double length, double width):(color)
    {
        _length = length;
        _width = width;
    }
    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _length * _width;
    }
}