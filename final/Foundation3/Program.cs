using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("Apt. 315 4907 Kuhlman Orchard", "West Marianna", "Georgia", "73857", "USA");
        string receptionAddress = address1.GetAddress();
        Receptions reception = new Receptions("Ashlyn and Bronco", "Ashlyn and Bronco's wedding reception", "June 1, 2024", "6:00 pm - 9:00 pm", $"{receptionAddress}", "Reception", "ashlyn@gmail.com");
        
        Console.WriteLine("**************************************");
        reception.ShortDescription();
        Console.WriteLine();
        reception.StandardDetails();
        Console.WriteLine();
        reception.ReceptionsFullDetails();
        Console.WriteLine("**************************************");

        Address address2 = new Address ("2040 Clarence St.", "Idaho Falls", "Idaho", "83402", "USA");
        string lectureAddress = address2.GetAddress();
        Lectures lecture = new Lectures("Book Club Lecture", "Talking with a local book club about authors newest book.", "March 23, 2024", "8:00 pm - 9:00 pm", $"{lectureAddress}", "Lecture", "Sandy Remington", 25);
        
        lecture.ShortDescription();
        Console.WriteLine();
        lecture.StandardDetails();
        Console.WriteLine();
        lecture.LectureFullDetails();
        Console.WriteLine("**************************************");


        Address address3 = new Address ("Esc. 550 Riera Monica 87", "San Fernando", "Man", "41824", "Mexico");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Ice Cream Social", "relaxed meet and greet with ice cream served to social interaction.", "June 15, 2024", "6:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");
    
        
        outdoor.ShortDescription();
        Console.WriteLine();
        outdoor.StandardDetails();
        Console.WriteLine();
        outdoor.OutdoorFullDetails();
        Console.WriteLine("**************************************");
        
    }
}