using System;

public class Journal
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
static public int DisplayMenu
{
    Console.WriteLine("Journals")
    {
        Console.WriteLine("1. to write");
        Console.WriteLine("2. to display");
        Console.WriteLine("3. to load");
        Console.WriteLine("4. to save");
        Console.WriteLine("5. to quit");
        var result = Console.ReadLine();
    }
}