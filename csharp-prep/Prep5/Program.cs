using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int sqNum = SquareNumber(favNum);
        DisplayResult(userName, sqNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum  = int.Parse(Console.ReadLine());
        return favNum;
    }
    static int SquareNumber(int favNum)
    {
        int sqNum = favNum * favNum;
        return sqNum;
    }
    static void DisplayResult(string userName, int sqNum)
    {
        Console.WriteLine($"{userName} the square of your number is {sqNum}");
    }
}