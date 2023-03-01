using System;

public class Square : Shape
{
    private double _Side;

    public Square (string color,double side): base(color)
    (
        _Side = side;
    )
    // Notice the use of the override keyword here

    public class Override double GetArea()
    (
       return _Side * _side;
    )
}
