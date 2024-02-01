using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("John", "Fractions");
    
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("John", "fractions", "4.6", "3-22");
        string summary = assign2.GetSummary();
        string list = assign2.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(list);
    
        WritingAssignment assign3 = new WritingAssignment("Mary Smith", "European History", "World War II");
        string summary1 = assign3.GetSummary();
        string writInfo = assign3.GetWritingInfo();
        Console.WriteLine(summary1);
        Console.WriteLine(writInfo);
    }
}