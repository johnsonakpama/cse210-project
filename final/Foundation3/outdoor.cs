using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;
    private string _weatherStatement;

    public OutdoorGathering(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
        _weatherStatement = weatherStatement;
    }
    public string GetOutdoorGathering()
    {
        return _weatherForecast;
    }
    public void SetOutdoorGathering()
    {
        _weatherForecast = weatherForecast;
    }
    public strring GetOutdoorGathering()
    {
        return _weatherStatement;
    }
    public void SetOutdoorGathering()
    {
        _weatherStatement = _weatherStatement;
    }
    public string GetFullWeatherForecast()
    {
        return $"{_description} {_title} {_date} {_lecture} {_weatherForecast}";
    }

}