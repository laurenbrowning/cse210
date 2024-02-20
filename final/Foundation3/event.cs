using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _eventType;

    public Event(string title, string description, string date, string time, string address, string type)
    {
        _title = title;
        _description = description;
        _date = date; 
        _time = time; 
        _address = address; 
        _eventType = type;
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Date: {_date}");
    }

    public void StandardDetails() 
    {
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void FullDetails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }
}