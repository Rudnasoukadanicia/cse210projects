using System;

using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();

    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {_comment.Count}");
    }

    public void DisplayAllComment()
    {
        foreach (Comment comment in _comment)
        {
            comment.DisplayComment();
        }
    }
}