using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    _comments: List<Comment>NumberOfComment();
    public string _Comment;

    public Video(string title, string author, int length, string Comment);
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<string>();

    }

    public void AddComment()
    {
        Comments.Add(comment);
    }

    public void DisplayComment()
    {
        foreach (string comment in Comments)
        {
           Console.WriteLine(comment); 
        }
    }

    
    public void Display()
    {
        Console.WriteLine($"{_title} {_author} {_length} {_Comment}");
    }

}