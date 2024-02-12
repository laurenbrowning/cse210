using System;
using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
     private int _bonus;
    private int _target;
    private int _stepCounter;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int stepCounter)
    {
        _name = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _target = target;
        _stepCounter = stepCounter;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringChecklisttarget = Console.ReadLine();
        _target = Convert.ToInt32(stringChecklisttarget);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonus = Console.ReadLine();
        _bonus = Convert.ToInt32(bonus);

        _stepCounter = 0;

    }

    public override bool IsComplete() 
    {
        if (_stepCounter >= _target) {
            return true;
        } else {
            return false;
        }
    }
    
    public override void RecordEvent()
    {
        _stepCounter ++;
    }

    public override int CalcAllPoints()
    {
        int points = 0;

        points = _stepCounter * _points;

        bool status = IsComplete();

        if (status == true) {
            points += _bonus;
        }

        return points;

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

        Console.Write($"[{statusSymbol}] {_name} ({_description}) -- Currently Completed {_stepCounter}/{_target}");
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"ChecklistGoal:" + _name + "," + _description + "," + _points.ToString() + "," + _bonus.ToString() + "," + _target.ToString() + "," + _stepCounter.ToString();
        return line;
    }

}





