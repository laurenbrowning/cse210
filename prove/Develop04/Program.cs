using System;

class Program
{
    static void Main(string[] args)
    {
         string input = "";

       
        

        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();

                    break;

                case "2":
                    ReflectionActivity reflectingActivity = new ReflectionActivity();
                    reflectingActivity.RunActivity();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();

                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();

                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter the number of the menu option. ");
                    break;
            }
        }
        Environment.Exit(0);
    }
    
}