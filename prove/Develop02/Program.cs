using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator prompt = new PromptGenerator(); 

        bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string newPrompt = prompt.GetRandomPrompt();
                        theJournal.AddEntry(newPrompt);
                        break;
                    case "2":
                        theJournal.DisplayAll();
                        break;
                    case "3":
                        theJournal.SaveToFile();
                        break;
                    case "4":
                        theJournal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("make a different choice.");
                        break;
                }
            }
            Console.WriteLine("See you tomorrow!");
        
    }

    
}