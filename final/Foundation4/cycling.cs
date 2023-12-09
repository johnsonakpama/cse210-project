using System;

public class Cycling : Activity
{
    private int _speed;

    public int Cycling(date DateTime, int minutes, double poolLength, int speed)
    {
        _speed = speed;
    }
    public override GetCyclingSpeed()
    {
        return $"cycling{_distance} mile per hour{_speed}";
    }
    GetCyclingSpeedSummer()
}