using System;

public class Assignment
{
    protected string _studName;
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        _studName = studentName;

        _topic = topic;

    }

    public string GetSummary()
    {
        return $"{_studName} - {_topic}"; 
    }

}