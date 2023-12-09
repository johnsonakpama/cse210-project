using System;

public class Running : Activity
{
    private double _distance;

    public double Running(date DateTime, int minutes, double poolLength, int speed, double distance)
    {
        _distance = distance;
    }

    public override GetRunningDistance()
    {
        return _distance;
    }
    GetRunningDistance();
}