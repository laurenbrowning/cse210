using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal() 
    {
        _name = "Test Name";
        _description = "Test Description";
        _points = 50;
        _isComplete = false;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    protected void CreateBaseGoal() 
    {   
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string stringpoints = (Console.ReadLine());
        _points = Convert.ToInt32(stringpoints);

        _isComplete = false;
    }

    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

    public virtual void CreateChildGoal()
    {

    }

    public virtual void RecordEvent() 
    {

    }

    public virtual bool IsComplete() 
    {
        return false;
    }

    public virtual void ListGoal() 
    {

    }

    public virtual int CalcAllPoints()
    {
        return 0;
    }
}
   