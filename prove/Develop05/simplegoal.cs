using System;

public class SimpleGoal : Goal
{
     public SimpleGoal()
    {
        _name = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _points = 50;
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = status;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void RecordEvent()
    {
        if (_isComplete == false) {
            _isComplete = true;
        } else {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_isComplete == true) {
            return true;
        } else {
            return false;
        }
    }

    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = IsComplete();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }
        Console.Write($"[{statusSymbol}] {_name} ({_description})");
    }
    
    public override int CalcAllPoints()
    {
        bool status = IsComplete();
        int aGP = 0;
        if (status == true) {
            aGP = _points;
        } else {
            aGP = 0;
        }
        return aGP;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal:{_name},{_description}{_points},{IsComplete().ToString()}";
        return line;
    }
}
