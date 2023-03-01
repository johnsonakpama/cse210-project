// See the comment below about the abstract method. Because we have an abstract method
// this class must also be declared as an abstract class
public abstract class Shape
{
    private string _Color;

    public shape (string color)
    {
        _Color = Color;
    }

    public string GetColor()
    {
        return _Color;
    } 
    public abstract double GetArea();
}