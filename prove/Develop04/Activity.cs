using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private List<string> animination = new List<string>()
    {"|", "/", "-", "\\"};

    public Activity(int duration)
    {
        _duration = duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to do this activity?");
        _duration = int.parse(Console.ReadLine());
        Console.Write ("Get ready...");
        Spinner(5);
    }

    public void EndMassage()
    {
        Console.Write($"You completed {_duration} seconds of the {_name} activity");
        Spinner(5);
    }

    public void counter(int duration)
    {
        for(int i = duration; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner(int duration)
    {
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(duration);
        while (DateTime.Now < endTime);
        {
            foreach(string character in animation);
            {
                Console.Write(character);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
            
        }
    }
}