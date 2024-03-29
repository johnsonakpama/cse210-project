using System;
public class Listing : Activity
{
     private Random random = new Random();
     private List<string> _prompts = new List<string>()
     {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
     };

     public Listing(int duration) : base()
     {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many as you in a certain area";
     }

    public void Execute()
    {
        int counter = 0;
        StartMessage()
        Console.WriteLine(GetRandomPrmpt());
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            string input = Console.WriteLine();
            Counter++
        }
        EndMassage();

    }
    
    private string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }


}