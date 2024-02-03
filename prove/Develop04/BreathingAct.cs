using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Mindful Breathing");
        SetDescription("Please follow the prompts to breathe in and out, focusing on your breath to help calm your mind.");

    }
    public void Run()
        {
            DateTime runTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();
        
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountDown(2);
        Console.WriteLine();
        Console.Write("Breathe out...");
        ShowCountDown(3);

        while (currentTime <= runTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(6);
            currentTime = DateTime.Now;
        }
    }
}
