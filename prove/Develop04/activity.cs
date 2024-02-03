using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 10;
    }
     public void SetName(string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void ShowStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void AskDuration()
    {
        Console.WriteLine();
        Console.Write("How many seconds would you like your session to run? ");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void RunActivity()
    {
        Console.Clear();
        ShowStartingMessage();
        AskDuration();
        GetReady();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int totalSecs)
    {
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;

        DateTime runTime = GetFutureTime(5);

        while(DateTime.Now < runTime)
        {
            char[] spinChars = new char[]{'|','/','-','\\'};
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                Thread.Sleep(spinWait);
            }
        }
        Console.CursorLeft = spinnerPosition;
        Console.Write(" ");
    }

    public void ShowCountDown(int totalSecs)
    {
        int timerPos = 25;
        int timerWait = 1000;

        timerPos = Console.CursorLeft;

        for (int i = 0; i <= totalSecs; i++)
        {
            Console.CursorLeft = timerPos;
            Console.Write(totalSecs - i);
            Thread.Sleep(timerWait);
        }
        Console.CursorLeft = timerPos;
        Console.Write(" ");
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }
    public DateTime GetFutureTime(int duration)
    {   
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }

    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        return currentTime;
    }
}
