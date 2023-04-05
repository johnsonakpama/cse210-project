using System;

public abstract class Activity
{
    private double _distance;
    private TimeSpan _duration;

    public Activity(double distance,TimeSpan duration)
    {
        _distance = distance;
        _duration = duration;
    }
    public virtual double GetDistance()
    {
        return _distance
    }
    public virtual GetSpeed()
    {
        return _distance/_duration.TotalHours;
    }
    public virtual TimeSpan GetPace()
    {
        return TimeSpan.FromHours(_duration.TotalHours/_distance);
    }
    public abstract string GetSummary();

}
public class Running :Activity
{
    private double = elevationGain;

    public Running(double distance,TimeSpan duration,double elevationGain):base(distance,duration)
    {
        _elevationGain = elevationGain;
    }
    public override string GetSummary()
    {
        return $"Ran{_distance} mile with{_elevationGain} feet of elevation gain in {_duration}";
    }
}
public class StationaryBike:Activity
{
    private double _resistance;

    public StationaryBike(double distance,TimeSpan duration,double resistance,):base(distance,duration)
    {
        _resistance = resistance;
    }
    public override double GetSpeed()
    {
        return _distance/_duration.TotalMinutes;
    }
    public override string GetSummary()
    {
        return $"Biked{_distance} mile with{_resistance} resistance in{_duration}";
    }
}
public class Swimming:Activity
{
    private _poolLength;

    public Swimming(double distance,TimeSpan duration,double poolLength):base(distance,duration)
    {
        _poolLength = poolLength;
    }
    public override TimeSpan GetPace()
    {
        return TimeSpan.FromMinutes(_duration.TotalMinutes/(_distance/_poolLength));
    }
    public override string GetSummary()
    {
        return $"Swam{_distance} yards with{_poolLength}-yard pool length in{_duration}";
    }
}
public class Program
{
    public static void Main(string[]args)
    {
        Running running = new(6.0,TimeSpan.FromMinutes(45),100);
        StationaryBike bike = new StationaryBike(10)
    }
}