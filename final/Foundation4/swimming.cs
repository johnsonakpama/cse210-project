using System;

public class Swimming : Activity
{
    private double _poolLength;

    public double Swimming(date DateTime, int minutes, double poolLength)
    {
        _poolLength = poolLength;
    }
    public override GetPoolLength()
    {
        return _poolLength;
    }

    GetSummarySwimming();

}