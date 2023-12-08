using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title,string description,string date,string time,string address)
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
    public String GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address;
    }
    public string GetShortDescriotion()
    {
        return $"{this.GetType().Name}:{this.title} {this.date}";
    }
    public class Lecture :Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title,string description,string date,string time,string address, string speaker,int capacity):base(title,description,date,time,address)
        {
            _speaker = speaker;
            _capacity = capacity;

        }
        public string GetSpeaker()
        {
            return _speaker;
        }
        public int GetCapacity()
        {
            return _capacity;
        }

    }
    public class Reception:Event
    {
        private string _rsvpEmail;

        public Reception(string title,string decription,string date,string time,string address,string rsvpEmail):base(title,description,date,time,address)
        {
            _rsvpEmail = rsvpEmail;
        }
        public string GetRsvpEmail()
        {
            return _rsvpEmail;
        }
    
    }
    public class OutdoorGathering:Event
    {
        private string _weatherForecast;

        public OutdoorGathering(string title,string description,string date,string time string address,string weatherForecast):base(title,description,date,time,address)
        {
            _weatherForecast = weatherForecast;
        }
        public string GetWeatherForecast()
        {
            return _weatherForecast;
        }
    }
}


    
    
    

    