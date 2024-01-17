using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
//Back in your Program.cs file, add code to your Main function.
// Create a new job instance named job1 .
// Set the member variables using the dot notation 
//(for example, job1._jobTitle = "Software Engineer";
// Verify that you can display the company of this job on the screen, 
//again using the dot notation to access the member variable.
// Create a second job, set its variables, 
//display this company on the screen as well. 
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._companyName = "Apple";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2023;
    
        Resume userResume = new Resume();
        userResume._name = "John Smith";

        userResume._jobs.Add(job1);
        userResume._jobs.Add(job2);
        userResume.Display();
    }

}