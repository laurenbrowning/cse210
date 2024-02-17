using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
        return;
    }
    public int NumOfComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
    public void DisplayInfo()
    {
         Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds");
        Console.WriteLine();
        int count = NumOfComments();
        Console.WriteLine($"Number of comments: {count}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }    
    }
}