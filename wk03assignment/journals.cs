using System;

public class Journal

public List<Entry> entries = new List<Entry>();

{
    public string _Write;
    public string _Display;
    public int _Load;
    public int _Save;
    public int _Quit;

    public void Display()
    {
        Console.WriteLine($"{_Write} {_Display} {_Load} {_Save} {_Quit}");
    }
}