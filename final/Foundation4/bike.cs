using System;

public class Biking : Activity
{
    private double _speed;

    public Biking(double length, double speed) : base(length)
    {
        _speed = speed;
    }

        public override double CalcDistance()
    {   
        double distance = Math.Round(GetLength() * CalcSpeed() / 60, 1);
        return distance;
    }

    public override double CalcSpeed()
    {
        return Math.Round(_speed, 1);
    }

    public override double CalcPace()
    {
        double pace = Math.Round(60 / CalcSpeed(), 1);
        return pace;
    }

    public override void Summary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} min) - Distance: {CalcDistance()} miles, Speed: {CalcSpeed()}, Pace: {CalcPace()} min per mile");
    }
}