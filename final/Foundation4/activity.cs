using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(date DateTime, minutes int)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual GetDateTime()
    {
        return _date;
    }
    public virtual GetMinutes()
    {
        return _minutes;
    }

    GetActivitySummary();
}    