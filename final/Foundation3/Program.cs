using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
    }
    Event event = new Event();
    event.SetTitle("The important of Technology");
    event.SetDescription("Exposing to benefit of Technology in our present world");
    event.SetDate("10:00am");
    event.SetDate("3rd -Dec-2023");
    event.SetAddress("HillStation Hotel");

    Console.WriteLine(event.GetFullDetails());

    Address address = new Address();
    address.SetStreet("#3 Murtala Express road Bukuru");
    address.SetCity("Jos");
    address.SetState("Plateau state");
    address.SetCountry("Nigeria");

    Console.WriteLine(address.GetFullAddress());

    Lecture lecture = new Lecture();
    lecture.SetSpeaker("Johnson Akpama");
    lecture.SetCapacity("500");

    Console.WriteLine(lecture.GetFullLecture());

    OutdoorGathering outdoorGathering = new OutdoorGathering();
    outdoorGathering.SetWeatherForecast("");
    outdoorGathering.SetWeatherStatement("Haze 37/13");

    Console.WriteLine(weatherForecast.GetFullWeatherForecast());

    Reception reception = new Reception();
    reception.SetRsvpEmail("jesuschristislord@gmail.com");

    Console.WriteLine(reception.GetFullReception());

    



}