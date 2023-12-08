using System;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate()
    {
        _date = date;
    }
    public string GetTime()
    {
        return _time;
    }
    public void SetTime()
    {
        _time = time;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress()
    {
        _address = address;
    }
    public string GetFullDetails()
    {
        return _fulldetails;
    }
    public string GetShortDescriotion()
    {
        return $"{_description} {_title} {_date}";
    }
}