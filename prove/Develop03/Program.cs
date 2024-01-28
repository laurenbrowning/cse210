using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("2 Kings", 6, 16, "'And he answered, Fear not: for they that be with us are more than they that be with them.'");
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nPress the enter key to keep going or type 'quit' to exit the program.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower()=="quit")
                break;

            if (!scripture.HideRandWords())
            {
                Console.WriteLine("\nYou did it!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress the enter key to keep going or type 'quit' to exit the program.");
        }    
    }
}