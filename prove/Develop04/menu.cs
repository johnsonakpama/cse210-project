using System;
public class menuOption
{
    private string _getStrted;
    private string _Breathein;

    private string _Breatheout;

    public menuOption(string getStarted, string Breathin, string Breatheout)
    {
        _getStrted = getStarted;
        _Breathein = Breathin;
        _Breatheout = Breatheout;
    }
    //Proving getter for our member variables

    public string getStarted()
    {
        return _getStrted;
    }

    public string Breathin()
    {
        return _Breathein;
    }
    public String Breatheout()
    {
        return _Breatheout;
    }

    public string GetSummary()
    {
        return _getStrted + "_" + _Breathein + "-"+_Breatheout;
    }
}