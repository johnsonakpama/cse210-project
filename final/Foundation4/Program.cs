using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
    }

    Activity activity = new Activity();
    activity.GetDate("09/12/2023");
    activity.GetDistance("400meters");

    Console.WriteLine(activity.GetActivitySummary());

    Swimming swimming = new Swimming();
    swimming.GetPoolLength(100meter);

    Console.WriteLine(swimming.GetSummarySwimming());

    Cycling cycling = new Cycling();
    cycling,GetCyclingSpeed("60 mile per hour");

    Console.WriteLine(cycling,Get.GetCyclingSpeed());

    Running running = new Running();
    running.GetRunningDistance(10km);

    Console. WriteLine(running.GetRunningDistance());
}