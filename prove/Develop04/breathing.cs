using System;

class program
{
    static void main(string[]args);


    Console.WriteLine("\n******Welcome to the breathe App*******\n");
    {    
          // This activity will help you relax
        Console.writeLine("This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on breathing.");
    }
    Console.ReadLine();

    public string breathe()
    {
        Console.WriteLine("breathein");
        Console.WriteLine("breatheout");
    }
    Console.ReadLine();

    private void  DisplayChoice()
    {
        string choice = @"Please celect one of the following choice
        1. getReady
        2. Quit
        What would you like to do?";
    }
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds();
    int i = 0;
    while (DateTime.Now < endTime)
    {
        string s= animinationString[1];
        Console.WriteLine("How many second did you need!");
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i++;
    }
    if(i > animinationString.count)
    {
        i = 0;
    }
    public class breathing: menuOption
    {
        private string _Breathein;

        public string GetBreathing():base(getReady,breathein,breatheout)

    }
    return _Breathe;

    Console.Write("Done");

    



}