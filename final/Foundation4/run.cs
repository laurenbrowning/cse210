using System;

public class Running : Activity
{
    private double _distance;

    public Running(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override double CalcDistance()
    {
        return Math.Round(_distance, 1);
    }

    public override double CalcSpeed()
    {
        double speed = Math.Round((CalcDistance() / GetLength()) * 60, 1);
        return speed;
    }

    public override double CalcPace()
    {
        double pace = Math.Round(GetLength() / CalcDistance(), 1);
        return pace;
    }

    public override void Summary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLength()} min) - Distance: {CalcDistance()} miles, Speed: {CalcSpeed()}, Pace: {CalcPace()} min per mile");
    }
}