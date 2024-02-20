using System;

public class Receptions : Event
{   
    private string _email;   

    public Receptions(string title, string description, string date, string time, string address, string type, string email) : base (title, description, date, time, address, type)
    {
        _email = email;
    }

    public void ReceptionsFullDetails()
    {   
        
        FullDetails();
        Console.WriteLine($"E-mail: {_email}");
    }
}