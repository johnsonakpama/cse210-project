using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }
    public void SetRsvpEmail()
    {
        _rsvpEmail = rsvpEmail;
    }
    public string GetFullReception()
    {
        return $"{_description} {_title} {_date} {_address} {_lecture} {_weatherForecast} {_reception}"
    }
    
}