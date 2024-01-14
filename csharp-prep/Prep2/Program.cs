using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage!");
        string userPerc = Console.ReadLine();

        int percent = int.Parse(userPerc);

        string letter = "";

    
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        { 
            letter = "B";
        }
        else if (percent >= 70)
        { 
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine($"You have a {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("Oh No, not quite high enough! Try again!");
        }
    }
}    