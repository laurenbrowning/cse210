using System;

public class ListingActivity : Activity
{
    private int _count;

     private List<string> _answerList = new List<string>();

    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

     public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    
    public void Run()
    {   
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"- {prompt} -");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime runTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();
            while (currentTime <= runTime)
            {
                Console.Write(">");
                _answerList.Add(Console.ReadLine());
                currentTime = DateTime.Now;
            }
            int _count = _answerList.Count;
            Console.WriteLine($"\nthere are {_count} items listed.");

    }

}