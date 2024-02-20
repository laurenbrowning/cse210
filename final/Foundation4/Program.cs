using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> exerciseList = new List<Activity>();

        Running running = new Running(25, 2);
        exerciseList.Add(running);
        Biking biking = new Biking(33, 11);
        exerciseList.Add(biking);
        Swimming swimming = new Swimming(55, 30);
        exerciseList.Add(swimming);

        foreach (Activity exercise in exerciseList)
        {
            exercise.Summary();
        }
    }
}