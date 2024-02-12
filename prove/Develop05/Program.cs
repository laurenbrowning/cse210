using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string menuSelection = "";

        GoalManager goals = new GoalManager();
            

        while (menuSelection != "6")
        {

            int points = goals.CalcAllPoints();

            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":

                    Console.WriteLine("The Types of Goals are: ");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    switch (goalType)
                    {
                        case "1":
                            SimpleGoal newSimpleGoal = new SimpleGoal();
                            newSimpleGoal.CreateChildGoal();
                            goals.addGoal(newSimpleGoal);
                            break;

                        case "2":
                            EternalGoal newEternalGoal = new EternalGoal();
                            newEternalGoal.CreateChildGoal();
                            goals.addGoal(newEternalGoal);
                            break;

                        case "3":
                            ChecklistGoal newChecklistGoal = new ChecklistGoal();
                            newChecklistGoal.CreateChildGoal();
                            goals.addGoal(newChecklistGoal);
                            break;

                        default:
                            Console.WriteLine("Invalid entry. Please try again.");
                            break;
                    }
                    break;

                case "2":
                    goals.ListGoals();
                    break;

                case "3":
                    goals.SaveGoals();
                    break;

                case "4":
                    goals.LoadGoals();
                    break;

                case "5":
                    goals.RecordEvent();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please select a valid number from the menu options.");
                    break;
            }
        }
    }
}
