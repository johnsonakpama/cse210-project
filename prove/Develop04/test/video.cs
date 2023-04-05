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
public class YouTubeVideo:Video
{
    public YouTubeVideo(string author,string title,TimeSpan runningTime):base(author,title,runningTime)
    {

    }
    public override void Play()
    {
        Console.WriteLine($"Playing{Title}by{Author} ({RunningTime})");
    }
}