using System;

using System. Collection.Geneeric;

public abstract class Goal
{
    public string Name { get; set; }

    public int Point { get; set; }

public Goal(string name, int points)
{
    Name = name;
    
    Points = points;
}

public abstract void RecordEvent();
public abstract string GetStatus();
}