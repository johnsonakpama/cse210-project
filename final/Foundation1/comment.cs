using System;

public class Comments
{
    public string _text;

    public List<Comment> _comments = new List<Comment>()
    
    public void Display()
    {
        Console.WriteLine($"Text: {_text}");

        Console.WriteLine($"Comment:");

        foreach(Comment comment in _Comment)
        {
            comment.Display();
        }
    }



} 