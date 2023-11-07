using System;

class Breathing : Activity
{
    public Breathing(int duration) : base(duration)
    {    
          // This activity will help you relax
          _name = "Breathing";
          _description ="This activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on breathing.";
    }

    public void Execute()
    {
        StartMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.now() < endTime)
        {
            Console.Write(Breath in...);
            Counter(5);
            Console.Write(Breath out...);
            Counter(5)
        }
        EndMassage();
    }
    

    
}