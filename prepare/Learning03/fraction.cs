using System;

public class Fraction
{
    private int _top;
    private int _button;

    public Fraction()
    {
        _top = -1;
        _button = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _button = 1;
    }
    public Fraction(int top, int button)
    {
        _top = top;
        _button = button;
    }
    public string GetFractionString()
    {
       //Notice that this is not store as a member variable.
    //It is just a temporately, local variable that will be recomputed each time is called.

    string text = $"{_top}/{_button}";
    return text;
 
    }
    public double GetDecimalValue()
    {
        //Notice that is not stored as a member variable.
        //Is will be recomputed each time this is called.
        return (double)_top / (double)_button
    }

}