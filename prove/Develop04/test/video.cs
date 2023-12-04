using System;

using System.Collection.Generic;

public abstract class video
{
    public string Author{get;set;}
    public string Title{get;set;}
    public TimeSpan RunningTime{get;set;}

    public List<string>Comments{get;set;}

    public Video(string author,string title,string TimeSpan runningTime)
    {
        Author = author;
        Title = title;
        RunningTime = runningTime
        Comments = new List<string>();

    }
    public abstract void play();

    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public void ShowComment()
    {
        foreach (string comment in Comments)
        {
           Console.WriteLine(comment); 
        }
    }


}
