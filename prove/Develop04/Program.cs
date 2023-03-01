using System;

class Program
{
    static void Main(string[] args);
    {
        Console. WriteLine("Going to sleep for a second");
        Thread.sleep(1000);
        Console.WriteLine("I'm back");
    }

    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(s);

    Thread.Sleep(3000);

    DateTime currentTime = DateTime.Now;

    if(currentTime< futureTime)
    {
        Console.WriteLine("We have not arrived at our future time yet---")
    }
    for(int i = 5; i > 0; i--)
    {
        Console.WriteLine(i);
        Thread.Sleep(1000);
    }
    List<string>animinationString = new list<string>();
    animinationString.Add("|");
    animinationString.Add("/");
    animinationString.Add("-");
    animinationString.Add("//");
    animinationString.Add("|");
    animinationString.Add("/");
    animinationString.Add("-");
    animinationString.Add("//");

    foreach(string s in animinationString)
    {
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
    DateTime StartTime = DateTime.Now;
    DateTime endTime = StartTime.AddSeconds(10);
     int i=0
     while(DateTime.Now < endTime)
     {
        string s = animinationString[1];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        1++;
     }
     if(i > animinationString.Count)
     {
        i = 0
     }
     Console.Write("Done");

}