using System;

public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string speaker, int capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetSpeaker()
    {
        _speaker = speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void SetCapacity()
    {
        _capacity = capacity;
    }
    public string GetFullLecture()
    {
        return $"{_description} {_title} {_date} {_address} {_lecture}"
    }
}