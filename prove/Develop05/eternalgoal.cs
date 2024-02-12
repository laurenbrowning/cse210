using System;

public class EternalGoal : Goal
{
    private int _stepCounter;

    public EternalGoal()
    {
        _name = "";
        _description = "";
        _points = 50;
        _stepCounter = 0;
    }
    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _stepCounter = 0;
    }
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal:" + _name + "," + _description + "," + _points.ToString();
        return line;
    }

    public override void RecordEvent()
    {
        _stepCounter ++;
    }
    public override int CalcAllPoints()
    {
        int points = _points;
        return points;
    }
}
