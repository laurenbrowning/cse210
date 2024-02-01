using System;
using System.Dynamic;
using System.Reflection;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo(string studentName, string topic, string title)
    {
        return $"{_studName} - {_topic} \n{_title}";
    }
}