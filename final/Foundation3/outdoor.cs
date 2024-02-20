using System; 

public class Outdoor : Event
{   
    private string _weather;   

    public Outdoor(string title, string description, string date, string time, string address, string type, string weather) : base (title, description, date, time, address, type)
    {
        _weather = weather;
    }

       public void OutdoorFullDetails()
    {
        FullDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
}